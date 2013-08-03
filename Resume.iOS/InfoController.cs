using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using FlyoutNavigation;
using Resume.Core;

namespace Resume
{
	public partial class InfoController : DialogViewController
	{
		FlyoutNavigationController nav;

		public InfoController (FlyoutNavigationController item) : base (UITableViewStyle.Grouped, null)
		{
			nav = item;

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Action, delegate {
				nav.ToggleMenu ();
			});
		}

		public async override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			await ResumeSharedController.Current.GetResumeAsync (Success, SomethingWentWrong);
		}

		void Success()
		{
			var infoSection = new Section() { 
				new StyledStringElement("Name",ResumeViewModel.Current.Info.Name,UITableViewCellStyle.Subtitle),
				new StyledStringElement ("Address", ResumeViewModel.Current.Info.Address, UITableViewCellStyle.Subtitle),
				new StyledStringElement("Location", ResumeViewModel.Current.Info.Location, UITableViewCellStyle.Subtitle),
				new StyledStringElement("Pnohe Number", ResumeViewModel.Current.Info.PhoneNumber, UITableViewCellStyle.Subtitle),
				new StyledStringElement("Email", ResumeViewModel.Current.Info.Email, UITableViewCellStyle.Subtitle)
			};

			var objectiveSection = new Section() { 
				new StyledMultilineElement("Objective",ResumeViewModel.Current.Objective, UITableViewCellStyle.Subtitle)
			};

			Root = new RootElement("Information"){
				infoSection,
				objectiveSection
			};
		}

		void SomethingWentWrong(Exception e)
		{

		}
	}
}
