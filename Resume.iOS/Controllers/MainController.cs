using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using System.Threading.Tasks;
using Resume.Core;
using FlyoutNavigation;
using Xamarin.Themes;

namespace Resume
{
	public partial class MainController : UIViewController
	{
		FlyoutNavigationController navController;
		string[] navOptions = new string[]{
			"MenuItem1".Localize(),
			"MenuItem2".Localize(),
			"MenuItem3".Localize(),
			"MenuItem4".Localize()
		};


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			navController = new FlyoutNavigationController ();
			navController.View.Frame = UIScreen.MainScreen.Bounds;			
			navController.NavigationTableView.BackgroundColor =UIColor.FromRGB(30,129,200);
			navController.NavigationTableView.Bounces = false;
			View.AddSubview (navController.View);

			var section = new Section ();
			section.AddAll(
				from page in navOptions
				select new FlyoutMenuElement (page) as Element);

			navController.NavigationRoot = new RootElement ("") {
				section
			};

			navController.ViewControllers = new UINavigationController[] {
				new UINavigationController(new InformationController(navController)),
				new UINavigationController(new EducationController(navController)),
				new UINavigationController(new ExperienceController(navController)),
				new UINavigationController(new KnowledgeController(navController))
			};
		}


	}
}
