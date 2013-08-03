using System;

namespace Resume.Core
{
	public class Education
	{
		public string Where {
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

		public string Title {
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

		public string Date {
			get{
				return string.Format ("{0}-{1}", Since.ToShortDateString (), Until.ToShortDateString ());
			}
		}

		public string Location {
			get{
				return string.Format ("{0}-{1}",City,Country);
			}
		}
	}
}

