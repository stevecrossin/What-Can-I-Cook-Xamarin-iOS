﻿using System;
using Xamarin.Forms;
using Xamarin.Auth;
using WhatCanICookForms;
using WhatCanICookForms.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using Android.App;

[assembly: ExportRenderer(typeof(LoginPage), typeof(LoginPageRender))]

namespace TestFacebookLogin.Droid
{
    public class LoginPageRender : PageRenderer
    {
        public LoginPageRender(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            var activity = this.Context as Activity;

            var auth = new OAuth2Authenticator(
                Configuration.ClientId, // your OAuth2 client id
                Configuration.Scope, // the scopes for the particular API you're accessing, delimited by " +" symbols
                new Uri(Configuration.AuthorizeUrl), // the auth URL for the service
                new Uri(Configuration.RedirectUrl)); // the redirect URL for the service

            auth.Completed += (sender, eventArgs) => {
                if (eventArgs.IsAuthenticated)
                {
                    App.SuccessfulLoginAction.Invoke();
                    App.SaveToken(eventArgs.Account.Properties["access_token"]);
                }
                else
                {
                    // The user cancelled
                }
            };

            activity.StartActivity(auth.GetUI(activity));
        }
    }
}