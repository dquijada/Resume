// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Resume
{
	[Register ("ResponsabilityCell")]
	partial class ResponsabilityCell
	{
		[Outlet]
		MonoTouch.UIKit.UITextView responsabilityLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (responsabilityLabel != null) {
				responsabilityLabel.Dispose ();
				responsabilityLabel = null;
			}
		}
	}
}
