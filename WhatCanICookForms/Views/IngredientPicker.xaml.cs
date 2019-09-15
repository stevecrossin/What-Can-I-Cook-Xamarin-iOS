using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class IngredientPicker : ContentPage
    {
        public IngredientPicker()
        {
            InitializeComponent();
        }
        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipeResults());
        }
    }
}
