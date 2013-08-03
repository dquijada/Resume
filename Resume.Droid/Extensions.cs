using System;
using Android.App;

namespace Resume.Droid
{
	public static class Extensions
	{
		public static string Localize(this int id, Fragment frag)
		{
			return frag.GetString (id);
		}

		public static string Localize(this int id, Activity act)
		{
			return act.GetString(id);
		}
	}
}

