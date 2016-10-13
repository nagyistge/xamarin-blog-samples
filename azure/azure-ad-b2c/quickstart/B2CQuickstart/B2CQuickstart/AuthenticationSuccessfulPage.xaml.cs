using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace B2CQuickstart
{
    public partial class AuthenticationSuccessfulPage : ContentPage
    {
        public string UserId { get; set; }
        public string ExpiresOn { get; set; }

        public AuthenticationSuccessfulPage(AuthenticationResult authenticationResult)
        {
            InitializeComponent();

            // Step #3: Display token information.

            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                // Step #4: Acquire token silently.
            }
            catch (Exception ex)
            {
                await Navigation.PushAsync(new LoginPage());
            }
        }
    }
}
