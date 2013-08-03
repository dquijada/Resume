// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Resume
{
	[Register ("ExperienceCell")]
	partial class ExperienceCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel dateLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView image { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel jobLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel locationLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (jobLabel != null) {
				jobLabel.Dispose ();
				jobLabel = null;
			}

			if (locationLabel != null) {
				locationLabel.Dispose ();
				locationLabel = null;
			}

			if (image != null) {
				image.Dispose ();
				image = null;
			}

			if (dateLabel != null) {
				dateLabel.Dispose ();
				dateLabel = null;
			}
		}
	}
}
