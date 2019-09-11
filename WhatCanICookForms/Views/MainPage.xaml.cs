using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using WhatCanICookForms.Views;

namespace WhatCanICookForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
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
