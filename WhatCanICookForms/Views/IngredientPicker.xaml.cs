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

        //Method to display contents of Ingredients DB on screen appearing
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //ListView is bound in IngredientPicker.xaml
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipeResults());
        }
    }
}
