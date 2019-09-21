using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
	struct PlaceHolder
	{
		public string Key { get; }
		public string FileLocation { get; }

		public Encoding FileEncoding { get; }

		public PlaceHolder(string key,string fileLocation, Encoding fileEncoding)
		{
			Key = key;
			FileLocation = fileLocation;
			FileEncoding = fileEncoding;
		}
	}
}
