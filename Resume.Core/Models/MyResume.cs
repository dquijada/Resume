using System;
using System.Collections.Generic;

namespace Resume.Core
{
	public class MyResume
	{
		public Information Info {
			get;
			set;
		}

		public List<Education> Education {
			get;
			set;
		}

		public List<Job> Experience {
			get;
			set;
		}

		public string Objective {
			get;
			set;
		}

		public List<string> Abilities {
			get;
			set;
		}

		public List<string> Knowledge {
			get;
			set;
		}
	}
}

