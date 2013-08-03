using System;

namespace Resume.Core
{
	public class Information
	{
		public string Name {
			get;
			set;
		}

		public string Address {
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

		public string PhoneNumber {
			get;
			set;
		}

		public string Email {
			get;
			set;
		}		

		public string Location {
			get{
				return string.Format ("{0}-{1}",City, Country);
			}
		}
	}
}

