using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace B2CQuickstart
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public async void LoginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Step #2: Authenticate with Microsoft Authentication Library (MSAL).
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error Authenticating", ex.Message, "OK");
            }
        }
    }
}
