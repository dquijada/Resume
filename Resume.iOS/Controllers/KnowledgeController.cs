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
	public partial class KnowledgeController : DialogViewController
	{
		FlyoutNavigationController nav;

		public KnowledgeController (FlyoutNavigationController item) : base (UITableViewStyle.Plain, null)
		{
			nav = item;

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Action, delegate {
				nav.ToggleMenu ();
			});
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var knowledgeSection = new Section { 
				from item in ResumeViewModel.Current.Knowledge
				select new CommonElement(item)
			};

			Root = new RootElement ("MenuItem4".Localize()) {
				knowledgeSection
			};

			var tableFooterImageView = new UIImageView (FitpulseTheme.SharedTheme.TableFooterBackground);
			TableView.TableFooterView = tableFooterImageView;

			FitpulseTheme.Apply (TableView);
		}
	}
}
