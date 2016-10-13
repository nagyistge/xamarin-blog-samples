using System;

using UIKit;
using Foundation;
using AVFoundation;
using System.Threading.Tasks;

namespace Camera
{
	public partial class ViewController : UIViewController
	{
		bool flashOn = false;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override async void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		async partial void TakePhotoButtonTapped (UIButton sender)
		{

		}

		partial void SwitchCameraButtonTapped (UIButton sender)
		{
			
		}

		partial void FlashButtonTapped (UIButton sender)
		{
			
		}
	}
}