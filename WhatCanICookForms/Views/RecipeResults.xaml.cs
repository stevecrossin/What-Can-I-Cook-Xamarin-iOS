using System;
using System.Collections.Generic;
using System.Web;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class RecipeResults : ContentPage
    {
        public RecipeResults(string query)
        {
            InitializeComponent();
            Browser.BackgroundColor = Color.FromHex("#fff5d5");
            Browser.Source = "https://cse.google.com/cse?cx=009486592663190426124:huyqrjp4vty&q=" + HttpUtility.UrlEncode(query);
        }
        private async void Home_Clicked(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
