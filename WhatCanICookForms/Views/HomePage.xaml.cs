using System;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class HomePage : ContentPage
    {
        /***********************
                METHODS
         **********************/

        //Constructor
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        /*
         * Button clicked event handler used to take users to Ingredient Picker screen
         */
        private async void Pick_Ingredients_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IngredientPicker());
        }

        /*
         * Button clicked event handler used to take users to Dietary preferences screen
         */
        private async void Dietary_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DietaryPreferences());
        }

        /*
         * Button clicked event handler used to take users to Pantry screen
         */
        private async void Pantry_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pantry());
        }
    }
}
