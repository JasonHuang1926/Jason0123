using System;

using UIKit;

namespace Jason.iOS
{
	public partial class MenuViewController : UIViewController
	{
		public MenuViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			btnMap.TouchUpInside += (sender, e) =>
			{
				PerformSegue("moveToMyMapViewSegue", this);
			};

			btnWeb.TouchUpInside += (sender, e) =>
			{
				PerformSegue("moveToMyWebViewSegue", this);
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

