// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Resume
{
	[Register ("EducationCell")]
	partial class EducationCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel dateLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView image { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel locationLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel titleLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel whereLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (dateLabel != null) {
				dateLabel.Dispose ();
				dateLabel = null;
			}

			if (image != null) {
				image.Dispose ();
				image = null;
			}

			if (titleLabel != null) {
				titleLabel.Dispose ();
				titleLabel = null;
			}

			if (whereLabel != null) {
				whereLabel.Dispose ();
				whereLabel = null;
			}

			if (locationLabel != null) {
				locationLabel.Dispose ();
				locationLabel = null;
			}
		}
	}
}
