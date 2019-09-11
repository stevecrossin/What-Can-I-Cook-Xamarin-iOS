using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WhatCanICookForms
{
    public partial class DietaryPreferences : ContentPage
    {
        public DietaryPreferences()
        {
            InitializeComponent();
        }
        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
