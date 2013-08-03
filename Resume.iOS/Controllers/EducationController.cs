using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using FlyoutNavigation;
using Resume.Core;
using Xamarin.Themes;

namespace Resume
{
	public partial class EducationController : DialogViewController
	{
		FlyoutNavigationController nav;
		public EducationController (FlyoutNavigationController item) : base (UITableViewStyle.Plain, null)
		{
			nav = item;

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Action, delegate {
				nav.ToggleMenu ();
			});
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var universitySection = new Section {
				from item in ResumeViewModel.Current.Education
				select new EducationElement(item)
			};

			Root = new RootElement ("MenuItem2".Localize()) {
				universitySection
			};

			var tableFooterImageView = new UIImageView (FitpulseTheme.SharedTheme.TableFooterBackground);
			TableView.TableFooterView = tableFooterImageView;

			FitpulseTheme.Apply (TableView);
		}
	}
}
