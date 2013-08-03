using System;
using System.Collections.Generic;

namespace Resume.Core
{
	public class ResumeViewModel
	{
		static ResumeViewModel _instance;

		public static ResumeViewModel Current {
			get{
				if (_instance == null)
					_instance = new ResumeViewModel ();

				return _instance;
			}
		}

		MyResume _resume;
		public MyResume Resume {
			set{
				_resume = value;
			}
		}

		public List<Education> Education {
			get{
				return _resume.Education;
			}
		}

		public List<Job> Experience {
			get{
				return _resume.Experience;
			}
		}

		public Information Info {
			get{
				return _resume.Info;
			}
		}

		public string Objective {
			get{
				return _resume.Objective;
			}
		}

		public List<string> Abilities {
			get{
				return _resume.Abilities;
			}
		}

		public List<string> Knowledge {
			get{
				return _resume.Knowledge;
			}
		}
	}
}

