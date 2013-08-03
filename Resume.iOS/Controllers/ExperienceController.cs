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
	public partial class ExperienceController : DialogViewController
	{
		FlyoutNavigationController nav;

		public ExperienceController (FlyoutNavigationController item) : base (UITableViewStyle.Plain, null)
		{
			nav = item;

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Action, delegate {
				nav.ToggleMenu ();
			});
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var jobSection = new Section () {				
				from item in ResumeViewModel.Current.Experience
				select new ExperienceElement(item)
			};

			Root = new RootElement ("MenuItem3".Localize()) {
				jobSection
			};

			var tableFooterImageView = new UIImageView (FitpulseTheme.SharedTheme.TableFooterBackground);
			TableView.TableFooterView = tableFooterImageView;

			FitpulseTheme.Apply (TableView);
		}
	}
}
