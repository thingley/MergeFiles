using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace MergeFiles
{
	public partial class Form1 : Form
	{
		private string _templateLocation;
		private string _templateEncoding;
		private string _outputLocation;
		private string _outputEncoding;
		private List<PlaceHolder> _placeHolders;

		#region Properties

		// read-only expression bodied property
		private bool HasErrorMessage => tsslError.Text != string.Empty;

		#endregion Properties

		public Form1()
		{
			InitializeComponent();
		}

		#region Event Handlers

		private void ButFind_Click(object sender, EventArgs e)
		{
			txtMergedFile.Text = string.Empty;

			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.CheckPathExists = true;
				ofd.Filter = "xml files (*.xml)|*.xml";
				ofd.FilterIndex = 1;
				ofd.RestoreDirectory = true;

				if (ofd.ShowDialog() == DialogResult.OK)
				{

					txtMergeFileXML.Text = ofd.FileName;

					SetErrorMessage(ValidateXML());
				}
			}
		}

		private void ButRun_Click(object sender, EventArgs e)
		{
			if (!HasErrorMessage)
			{
				SetErrorMessage(ParseXML());
			}

			if (!HasErrorMessage)
			{
				SetErrorMessage(PerformMerge());
			}
		}

		private void TxtSave_Click(object sender, EventArgs e)
		{
			if (!HasErrorMessage)
			{
				SetErrorMessage(SaveOutput());
			}
		}

		#endregion Event Handlers

		#region Action Methods

		private string ValidateXML()
		{
			return ValidateXML_METHOD1();
		}

		private string ValidateXML_METHOD1()
		{
			string result = string.Empty;

			XmlReaderSettings readerSettings = new XmlReaderSettings()
			{
				IgnoreComments = true,
				IgnoreWhitespace = true,
				ValidationType = ValidationType.Schema,
				ValidationFlags = XmlSchemaValidationFlags.ReportValidationWarnings,
			};

			readerSettings.Schemas.Add(null, "MergeFiles.xsd");

			try
			{
				using (XmlReader reader = XmlReader.Create(txtMergeFileXML.Text, readerSettings))
				{
					while (reader.Read())
					{ }
				}
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}

			return result;
		}

		private string ValidateXML_METHOD2()
		{
			string result = string.Empty;

			try
			{
				XmlDocument xml = new XmlDocument();

				xml.Load(txtMergeFileXML.Text);
				xml.Schemas.Add(null, "MergeFiles.xsd");
				xml.Validate(null);
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}

			return result;
		}

		private string ParseXML()
		{
			string result = string.Empty;

			_placeHolders = new List<PlaceHolder>();

			XmlReaderSettings readerSettings = new XmlReaderSettings()
			{
				IgnoreComments = true,
				IgnoreWhitespace = true,
			};

			try
			{
				using (XmlReader reader = XmlReader.Create(txtMergeFileXML.Text, readerSettings))
				{
					reader.MoveToContent();
					reader.ReadStartElement("merge");

					reader.ReadStartElement("template");
					_templateLocation = reader.ReadElementContentAsString("location", "").Trim();
					_templateEncoding = reader.ReadElementContentAsString("encoding", "").Trim();
					reader.ReadEndElement();

					reader.ReadStartElement("output");
					_outputLocation = reader.ReadElementContentAsString("location", "").Trim();
					_outputEncoding = reader.ReadElementContentAsString("encoding", "").Trim();

					while (reader.ReadToFollowing("placeholder"))
					{
						reader.ReadStartElement("placeholder");
						string key = reader.ReadElementContentAsString("key", "").Trim() ;
						string location = reader.ReadElementContentAsString("location", "").Trim();
						string encoding = reader.ReadElementContentAsString("encoding", "").Trim();
						PlaceHolder placeHolder = new PlaceHolder(key, location, GetEncoding(encoding));
						_placeHolders.Add(placeHolder);
					}
				}
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}

			return result;
		}

		private string PerformMerge()
		{
			string result = string.Empty;

			try
			{
				string output = File.ReadAllText(_templateLocation, GetEncoding(_templateEncoding));

				foreach (PlaceHolder placeHolder in _placeHolders)
				{
					string replacementText = File.ReadAllText(placeHolder.FileLocation, placeHolder.FileEncoding);
					output = output.Replace(placeHolder.Key, replacementText);
				}

				txtMergedFile.Text = output;
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}

			return result;
		}

		private string SaveOutput()
		{
			string result = string.Empty;

			try
			{
				File.WriteAllText(_outputLocation, txtMergedFile.Text, GetEncoding(_outputEncoding));
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}

			return result;
		}

		#endregion Action Methods

		#region Helper Methods

		private Encoding GetEncoding(string encoding)
		{
			Encoding result = null;

			switch (encoding)
			{
				case "ASCII":
					result = Encoding.ASCII;
					break;
				case "UTF8":
					result = Encoding.UTF8;
					break;
				default: throw new ArgumentException("Unrecognised encoding - currently accepted encoding values are ASCII and UTF8.");
					break;
			}

			return result;
		}

		private void SetErrorMessage(string errorMessage)
		{
			tsslError.Text = errorMessage;
		}

		#endregion Helper Methods
	}
}
