using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace B2CQuickstart
{
    public partial class App : Application
    {
        public static PublicClientApplication AuthenticationClient { get; set; }

        // TODO #1: Add Azure AD B2C tenant information.
        public static string ClientId = "8ca648fd-2dc3-4ff1-aa4c-e9bd5543f2d0";
        public static string SignUpSignInPolicy = "B2C_1_SignInSignUp";
        public static string[] Scopes = { ClientId };
        public static string Authority = "https://login.microsoftonline.com/momentsapp.onmicrosoft.com/";
        public App()
        {
            InitializeComponent();

            AuthenticationClient = new PublicClientApplication(ClientId);

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
