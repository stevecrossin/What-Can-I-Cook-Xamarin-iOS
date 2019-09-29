using System;
using Xamarin.Forms;
using WhatCanICookForms.Controls;
using WhatCanICookForms.Views;

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

            ImageButton pickIngredients = new ImageButton();
            pickIngredients.Source = "pickingredients.png";
            pickIngredients.Clicked += Pick_Ingredients_Clicked;
            pickIngredients.Margin = new Thickness(20, 50, 20, 30);
            pickIngredients.HorizontalOptions = LayoutOptions.CenterAndExpand;


            ImageButton dietaryneeds = new ImageButton();
            dietaryneeds.Source = "dietaryneeds.png";
            dietaryneeds.Clicked += Dietary_Clicked;
            dietaryneeds.Margin = new Thickness(20, 0, 20, 30);
            dietaryneeds.HorizontalOptions = LayoutOptions.CenterAndExpand;

            ImageButton pantry = new ImageButton();
            pantry.Source = "pantry.png";
            pantry.Clicked += Pantry_Clicked;
            pantry.Margin = new Thickness(20, 0, 20, 30);
            pantry.HorizontalOptions = LayoutOptions.CenterAndExpand;

            AdmobControl admobControl = new AdmobControl()

            {
                AdUnitId = AppConstants.BannerId
            };
            admobControl.HorizontalOptions = LayoutOptions.CenterAndExpand;
            admobControl.VerticalOptions = LayoutOptions.EndAndExpand;


            Content = new StackLayout()
            {
                Children = { pickIngredients, dietaryneeds, pantry, admobControl } //admobControl 

            };
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
