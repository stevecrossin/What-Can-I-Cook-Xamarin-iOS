using System;
using Xamarin.Forms;
using Xamarin.Auth;
using WhatCanICookForms;
using WhatCanICookForms.iOS;
using Xamarin.Forms.Platform.iOS;
using WhatCanICookForms.Views;
using WhatCanICookForms.ViewModels;

[assembly: ExportRenderer(typeof(LoginPage), typeof(LoginPageRenderer))]

namespace WhatCanICookForms.iOS
{
    public class LoginPageRenderer : PageRenderer
    {
        /***********************
                METHODS
         **********************/

        /*
         * Method to setup the login page
         */
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            var auth = new OAuth2Authenticator(
                Configuration.ClientId, // your OAuth2 client id
                Configuration.Scope, // the scopes for the particular API you're accessing, delimited by " +" symbols
                new Uri(Configuration.AuthorizeUrl), // the auth URL for the service
                new Uri(Configuration.RedirectUrl)); // the redirect URL for the service

            //Handling the Completed event
            auth.Completed += (sender, eventArgs) => {
                // We presented the UI, so it's up to us to dimiss it on iOS.
                DismissViewController(true, null);
                if (eventArgs.IsAuthenticated)
                {
                    // Use eventArgs.Account to do wonderful things
                    App.SaveToken(eventArgs.Account.Properties["access_token"]);
                    App.SuccessfulLoginAction.Invoke();
                }
                else
                {
                    // The user cancelled
                    App.FailedLoginAction.Invoke();
                }
            };

            //Proceed to next screen
            PresentViewController(auth.GetUI(), true, null);
        }
    }
}
