using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using Resume.Core;
using Xamarin.Themes;

namespace Resume
{
	public partial class ResponsabilityController : DialogViewController
	{
		List<string> responsabilities;

		public ResponsabilityController (List<string> items) : base (UITableViewStyle.Plain, null)
		{
			responsabilities = items;
			Pushing = true;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var responsabilitySection = new Section {
				from item in responsabilities
				select new CommonElement(item)
			};

			Root = new RootElement ("Responsabilities") {
				responsabilitySection
			};

			var tableFooterImageView = new UIImageView (FitpulseTheme.SharedTheme.TableFooterBackground);
			TableView.TableFooterView = tableFooterImageView;

			FitpulseTheme.Apply (TableView);
		}
	}
}
