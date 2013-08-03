using System;
using System.Collections.Generic;

namespace Resume.Core
{
	public class Job
	{
		public string Name {
			get;
			set;
		}

		public string Country {
			get;
			set;
		}

		public string City {
			get;
			set;
		}

		public DateTime Since {
			get;
			set;
		}

		public DateTime Until {
			get;
			set;
		}

		public List<string> Responsabilities {
			get;
			set;
		}

		public string Location {
			get{
				return string.Format ("{0}-{1}",City,Country);
			}
		}

		public string Date {
			get{
				return string.Format ("{0}-{1}",Since.ToShortDateString(), Until.ToShortDateString());
			}
		}


	}
}

