using System;
using System.Collections.Generic;
using System.Web;
using WhatCanICookForms.ViewModels;
using Xamarin.Forms;
using Plugin.Share;

namespace WhatCanICookForms.Views
{
    public partial class RecipeResults : ContentPage
    {
        string url;

        public RecipeResults(string query)
        {
            InitializeComponent();
            Browser.BackgroundColor = Color.FromHex("#fff5d5");
            //use HttpUtility to encode url query string
            Browser.Source = "https://cse.google.com/cse?cx=009486592663190426124:huyqrjp4vty&q=" + HttpUtility.UrlEncode(query);

            //Get URL of selected recipe
            Browser.Navigated += (object sender, WebNavigatedEventArgs e) =>
            {
                //Don't save the URL if it's the Google search URL
                if (!e.Url.Contains("google"))
                {
                    url = e.Url;
                }
            };
        }
        //Navigate to HomePage activity if Home is clicked.
        private async void Home_Clicked(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new HomePage());
        }

        //Button to share recipe using methods available to device (messaging, email etc...)
        private async void Share_Clicked(object sender, EventArgs e)
        {
            await CrossShare.Current.Share(new Plugin.Share.Abstractions.ShareMessage
            {
                Text = "I want to share this recipe with you!",
                Title = "What Can I Cook?",
                Url = url
            });

        }
    }
}
