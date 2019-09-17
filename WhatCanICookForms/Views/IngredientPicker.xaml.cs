using System;
using System.Collections.Generic;
using WhatCanICookForms.Models;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class IngredientPicker : ContentPage
    {
        public IngredientPicker()
        {
            InitializeComponent();

            //SECTION FOR TESTING AT THIS STAGE
            listView.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Ingredient ingredient = App.Database.GetItems(e.SelectedItemIndex + 1);
                    ingredient.Selected = 1;

                    Console.WriteLine($"{ingredient.Name} selected value is {ingredient.Selected}");
                }
            };

            Ingredient testIngredient = App.Database.GetItems(3);
            Console.WriteLine($"{testIngredient.Name} selected value is {testIngredient.Selected}");
        }

        //Method to display contents of Ingredients DB on screen appearing
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //ListView is bound in IngredientPicker.xaml
            listView.ItemsSource = App.Database.GetItems();
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipeResults());

        }

    }
}
