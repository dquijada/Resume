using System;
using MonoTouch.Foundation;

namespace Resume
{
	public static class Extensions
	{
		public static string Localize(this string item)
		{
			return NSBundle.MainBundle.LocalizedString (item, "","");
		}
	}
}

