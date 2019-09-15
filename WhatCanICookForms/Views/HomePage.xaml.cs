using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void Pick_Ingredients_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IngredientPicker());
        }

        private async void Dietary_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DietaryPreferences());
        }

        private async void Pantry_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pantry());
        }
    }
}
