using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Themes;
using Resume.Core;
using FlyoutNavigation;
using BigTed;

namespace Resume
{
	public partial class InformationController : UIViewController
	{
		FlyoutNavigationController nav;

		public InformationController (FlyoutNavigationController item) : base ("InformationController", null)
		{
			nav = item;

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Action, delegate {
				nav.ToggleMenu ();
			});
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public async override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Title = "MenuItem1".Localize();
			ResumeSharedController.Current.Address = "ResumeUrl".Localize ();
			await ResumeSharedController.Current.GetResumeAsync (Success, SomethingWentWrong);
		}

		void Success()
		{
			FitpulseTheme.Apply ();
			InitializeValues ();
			ApplyThemes ();
		}

		void SomethingWentWrong(Exception e){
			BTProgressHUD.ShowErrorWithStatus ("Fail".Localize());
		}

		void ApplyThemes()
		{
			var mainColor = UIColor.FromRGB (151, 157, 155);

			nameLabel.Font = UIFont.FromName ("HelveticaNeue-Bold", 13);
			nameLabel.TextColor = UIColor.FromRGB (101, 107, 105);
			nameLabel.BackgroundColor = UIColor.Clear;

			emailLabel.Font = UIFont.FromName ("HelveticaNeue", 12);
			emailLabel.TextColor = UIColor.FromRGB (101, 107, 105);
			emailLabel.BackgroundColor = UIColor.Clear;

			phoneLabel.Font = UIFont.FromName ("HelveticaNeue", 12);
			phoneLabel.TextColor = UIColor.FromRGB (101, 107, 105);
			phoneLabel.BackgroundColor = UIColor.Clear;

			addressLabel.Font = UIFont.FromName ("HelveticaNeue", 14);
			addressLabel.TextColor = mainColor;
			addressLabel.BackgroundColor = UIColor.Clear;

			locationLabel.Font = UIFont.FromName ("HelveticaNeue", 14);
			locationLabel.TextColor = mainColor;
			locationLabel.BackgroundColor = UIColor.Clear;

			objectiveText.Font = UIFont.FromName ("HelveticaNeue", 14);
			objectiveText.TextColor = mainColor;
			objectiveText.BackgroundColor = UIColor.Clear;
			objectiveText.SizeToFit ();

			objectiveTitle.Font = UIFont.FromName ("HelveticaNeue-Bold", 19);
			objectiveTitle.TextColor = mainColor;
			objectiveTitle.BackgroundColor = UIColor.Clear;

			addressTitle.Font = UIFont.FromName ("HelveticaNeue-Bold", 19);
			addressTitle.TextColor = mainColor;
			addressTitle.BackgroundColor = UIColor.Clear;

			var image = UIImage.FromFile ("profile-stats-bg.png");
			header.BackgroundColor = UIColor.FromPatternImage (image);
			header.Frame = new RectangleF (header.Frame.Location, image.Size);

			profileImage.Image = UIImage.FromFile ("daniel.png");
		}

		void InitializeValues()
		{
			nameLabel.Text = ResumeViewModel.Current.Info.Name;
			emailLabel.Text = ResumeViewModel.Current.Info.Email;
			phoneLabel.Text = ResumeViewModel.Current.Info.PhoneNumber;
			addressLabel.Text = ResumeViewModel.Current.Info.Address;
			locationLabel.Text = ResumeViewModel.Current.Info.Location;
			objectiveText.Text = ResumeViewModel.Current.Objective;
			objectiveTitle.Text = "ObjectiveTitle".Localize();
			addressTitle.Text = "AddressTitle".Localize();
		}
	}
}

