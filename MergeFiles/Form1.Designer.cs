namespace MergeFiles
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtMergeFileXML = new System.Windows.Forms.TextBox();
			this.lblMergeFileXML = new System.Windows.Forms.Label();
			this.butFind = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtMergedFile = new System.Windows.Forms.TextBox();
			this.lblMergedFile = new System.Windows.Forms.Label();
			this.txtSave = new System.Windows.Forms.Button();
			this.butRun = new System.Windows.Forms.Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslError = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMergeFileXML
			// 
			this.txtMergeFileXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMergeFileXML.Location = new System.Drawing.Point(90, 23);
			this.txtMergeFileXML.Name = "txtMergeFileXML";
			this.txtMergeFileXML.ReadOnly = true;
			this.txtMergeFileXML.Size = new System.Drawing.Size(656, 20);
			this.txtMergeFileXML.TabIndex = 0;
			// 
			// lblMergeFileXML
			// 
			this.lblMergeFileXML.AutoSize = true;
			this.lblMergeFileXML.Location = new System.Drawing.Point(3, 20);
			this.lblMergeFileXML.Name = "lblMergeFileXML";
			this.lblMergeFileXML.Size = new System.Drawing.Size(81, 13);
			this.lblMergeFileXML.TabIndex = 1;
			this.lblMergeFileXML.Text = "Merge File XML";
			// 
			// butFind
			// 
			this.butFind.Location = new System.Drawing.Point(752, 23);
			this.butFind.Name = "butFind";
			this.butFind.Size = new System.Drawing.Size(45, 23);
			this.butFind.TabIndex = 2;
			this.butFind.Text = "Find";
			this.butFind.UseVisualStyleBackColor = true;
			this.butFind.Click += new System.EventHandler(this.ButFind_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.lblMergeFileXML, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtMergeFileXML, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.butFind, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtMergedFile, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblMergedFile, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.statusStrip, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.butRun, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtSave, 2, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// txtMergedFile
			// 
			this.txtMergedFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMergedFile.Location = new System.Drawing.Point(90, 52);
			this.txtMergedFile.Multiline = true;
			this.txtMergedFile.Name = "txtMergedFile";
			this.txtMergedFile.ReadOnly = true;
			this.tableLayoutPanel1.SetRowSpan(this.txtMergedFile, 2);
			this.txtMergedFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMergedFile.Size = new System.Drawing.Size(656, 375);
			this.txtMergedFile.TabIndex = 3;
			// 
			// lblMergedFile
			// 
			this.lblMergedFile.AutoSize = true;
			this.lblMergedFile.Location = new System.Drawing.Point(3, 49);
			this.lblMergedFile.Name = "lblMergedFile";
			this.lblMergedFile.Size = new System.Drawing.Size(62, 13);
			this.lblMergedFile.TabIndex = 4;
			this.lblMergedFile.Text = "Merged File";
			// 
			// txtSave
			// 
			this.txtSave.Location = new System.Drawing.Point(752, 404);
			this.txtSave.Name = "txtSave";
			this.txtSave.Size = new System.Drawing.Size(45, 23);
			this.txtSave.TabIndex = 2;
			this.txtSave.Text = "Save";
			this.txtSave.UseVisualStyleBackColor = true;
			this.txtSave.Click += new System.EventHandler(this.TxtSave_Click);
			// 
			// butRun
			// 
			this.butRun.Location = new System.Drawing.Point(752, 52);
			this.butRun.Name = "butRun";
			this.butRun.Size = new System.Drawing.Size(45, 23);
			this.butRun.TabIndex = 2;
			this.butRun.Text = "Run";
			this.butRun.UseVisualStyleBackColor = true;
			this.butRun.Click += new System.EventHandler(this.ButRun_Click);
			// 
			// statusStrip
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.statusStrip, 3);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.tsslError});
			this.statusStrip.Location = new System.Drawing.Point(0, 430);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 20);
			this.statusStrip.TabIndex = 5;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 15);
			// 
			// tsslError
			// 
			this.tsslError.Name = "tsslError";
			this.tsslError.Size = new System.Drawing.Size(0, 15);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MergeFiles";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtMergeFileXML;
		private System.Windows.Forms.Label lblMergeFileXML;
		private System.Windows.Forms.Button butFind;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtMergedFile;
		private System.Windows.Forms.Button butRun;
		private System.Windows.Forms.Button txtSave;
		private System.Windows.Forms.Label lblMergedFile;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel tsslError;
	}
}

