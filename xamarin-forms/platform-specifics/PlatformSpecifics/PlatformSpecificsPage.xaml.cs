using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
	public partial class PlatformSpecificsPage : ContentPage
	{
		public PlatformSpecificsPage()
		{
			InitializeComponent();

			button1.Clicked += (sender, e) =>
			{
				logo.On<Xamarin.Forms.PlatformConfiguration.iOS>().UseBlurEffect(BlurEffectStyle.None);
			};

			button2.Clicked += (sender, e) =>
			{
				logo.On<Xamarin.Forms.PlatformConfiguration.iOS>().UseBlurEffect(BlurEffectStyle.ExtraLight);
			};

			button3.Clicked += (sender, e) =>
			{
				logo.On<Xamarin.Forms.PlatformConfiguration.iOS>().UseBlurEffect(BlurEffectStyle.Light);
			};

			button4.Clicked += (sender, e) =>
			{
				logo.On<Xamarin.Forms.PlatformConfiguration.iOS>().UseBlurEffect(BlurEffectStyle.Dark);
			};
		}
	}
}
