using System;

using UIKit;
using Speech;
using Foundation;

namespace SpeechRecognition
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			PerformSpeechRecognitionButton.TouchUpInside += (sender, e) =>
			{
				var url = NSBundle.MainBundle.GetUrlForResource(AudioUrlTextField.Text, "mp3");
				RecognizeSpeech(url);
			};
		}

		public void RecognizeSpeech(NSUrl url)
		{
			var recognizer = new SFSpeechRecognizer(new NSLocale("en_US"));

			// Is the default language supported?
			if (recognizer == null)
				return;
			
			// Create recognition task and start recognition
			var request = new SFSpeechUrlRecognitionRequest(url);
			recognizer.GetRecognitionTask(request, (SFSpeechRecognitionResult result, NSError err) =>
			{
				// Was there an error?
				if (err != null)
				{
					var alertViewController = UIAlertController.Create("Error",
																   $"An error recognizing speech ocurred: {err.LocalizedDescription}",
																   UIAlertControllerStyle.Alert);
					PresentViewController(alertViewController, true, null);
				}
				else
				{
					if (result.Final)
					{
						InvokeOnMainThread(() =>
						{
							SpeechToTextView.Text = result.BestTranscription.FormattedString;
						});
					}
				}
			});
		}
	}
}
