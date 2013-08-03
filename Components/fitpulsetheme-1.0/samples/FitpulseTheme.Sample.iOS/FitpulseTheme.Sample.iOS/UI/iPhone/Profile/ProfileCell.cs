using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Themes;
using Xamarin.Controls.iOS.ProgressBar;

namespace ThemeSample.UI.iPhone {
	public class ProfileCell : UITableViewCell {
		public static readonly NSString Key = new NSString ("ProfileCell");

		public ProgressBar ProgressBar { get; private set; }
		public UILabel TitleLabel { get; private set;}
		public UIImageView Icon { get; private set; }
		public UIImageView IconFrame { get; private set; }		

		public ProfileCell () : base (UITableViewCellStyle.Default, Key)
		{
			SelectionStyle = UITableViewCellSelectionStyle.None;

			InitSubviews ();
		}

		private void InitSubviews ()
		{
			ProgressBar = new ProgressBar (new RectangleF (74, 29, 230, 20));
			TitleLabel = new UILabel (new RectangleF (74, 7, 226, 22));
			Icon = new UIImageView (new RectangleF (13, 10, 52, 52));
			IconFrame = new UIImageView (new RectangleF (12, 9, 54, 54));

			TitleLabel.Font = UIFont.FromName ("HelveticaNeue-Bold", 16);
			TitleLabel.TextColor = FitpulseTheme.SharedTheme.MainColor;

			TitleLabel.BackgroundColor = UIColor.Clear;

			AddSubviews (Icon, IconFrame, TitleLabel, ProgressBar);
		}
	}
}

