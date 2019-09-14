using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class RecipeResults : ContentPage
    {
        public RecipeResults()
        {
            InitializeComponent();
            Browser.BackgroundColor = Color.Transparent;
            Browser.Source = "https://cse.google.com/cse/publicurl?cx=015236496974186256374:d0qdoev25cg&q=";
        }
        /*private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }*/
    }
}
