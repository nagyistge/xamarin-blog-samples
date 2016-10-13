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

        // Step #1: Add Azure AD B2C tenant information.
        public static string ClientId = "{APP-CLIENT-ID-HERE}";
        public static string SignUpSignInPolicy = "{POLICY-NAME-HERE}";
        public static string Authority = "https://login.microsoftonline.com/{YOUR-B2C-TENANT-NAME}.onmicrosoft.com/";
        public static string[] Scopes = { ClientId };

        public App()
        {
            InitializeComponent();

            AuthenticationClient = new PublicClientApplication(ClientId);

            MainPage = new NavigationPage (new LoginPage());
        }
    }
}
