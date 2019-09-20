using System;
using System.Collections.Generic;
using WhatCanICookForms.ViewModels;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class Pantry : ContentPage
    {
        PantryViewModel ViewModel { get; set; } = new PantryViewModel();
        public Pantry()
        {
            InitializeComponent();
            BindingContext = ViewModel;
        }
        private async void Search_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new SelectedIngredients(ViewModel.GetSelectedIngredients(), true));
            /*
            //FOR TESTING
            string testString = ViewModel.CreateSearchString();
            Console.WriteLine($"Search string is {testString}");

            await Navigation.PushAsync(new RecipeResults(testString));
            */
        }


        private void sb_TextChanged(object sender, EventArgs e)
        {
            ViewModel.ApplyFilter();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.ApplyChanges();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.ApplyFilter();
        }
    }
}
