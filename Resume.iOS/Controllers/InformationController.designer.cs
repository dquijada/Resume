// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Resume
{
	[Register ("InformationController")]
	partial class InformationController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel addressLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel addressTitle { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel emailLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView header { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel locationLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel nameLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView objectiveText { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel objectiveTitle { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel phoneLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView profileImage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addressLabel != null) {
				addressLabel.Dispose ();
				addressLabel = null;
			}

			if (addressTitle != null) {
				addressTitle.Dispose ();
				addressTitle = null;
			}

			if (emailLabel != null) {
				emailLabel.Dispose ();
				emailLabel = null;
			}

			if (header != null) {
				header.Dispose ();
				header = null;
			}

			if (locationLabel != null) {
				locationLabel.Dispose ();
				locationLabel = null;
			}

			if (nameLabel != null) {
				nameLabel.Dispose ();
				nameLabel = null;
			}

			if (objectiveText != null) {
				objectiveText.Dispose ();
				objectiveText = null;
			}

			if (objectiveTitle != null) {
				objectiveTitle.Dispose ();
				objectiveTitle = null;
			}

			if (phoneLabel != null) {
				phoneLabel.Dispose ();
				phoneLabel = null;
			}

			if (profileImage != null) {
				profileImage.Dispose ();
				profileImage = null;
			}
		}
	}
}
