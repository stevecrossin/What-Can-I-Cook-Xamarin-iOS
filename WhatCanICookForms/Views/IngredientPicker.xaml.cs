using System;
using System.Collections.Generic;
using WhatCanICookForms.Models;
using WhatCanICookForms.ViewModels;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class IngredientPicker : ContentPage
    {
        IngredientPickerViewModel ViewModel { get; set; } = new IngredientPickerViewModel();

        public IngredientPicker()
        {
            InitializeComponent();
            BindingContext = ViewModel;
            //Update selected ingredient
            listView.ItemSelected += (sender, e) =>
            {
                //Null check
                if (e.SelectedItem != null)
                {
                    //Call UpdateSelectedIngredients() from IngredientPickerViewModel
                    ViewModel.UpdateSelectedIngredients(e.SelectedItemIndex + 1);

                    //FOR TESTING
                    Console.WriteLine($"{App.Database.GetItems(e.SelectedItemIndex + 1).Name} selected value is {App.Database.GetItems(e.SelectedItemIndex + 1).Selected}");
                }
            };

            //FOR TESTING
            Ingredient testIngredient = App.Database.GetItems(3);
            Console.WriteLine($"{testIngredient.Name} selected value is {testIngredient.Selected}");
        }

        //Method to display contents of Ingredients DB on screen appearing
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.ApplyFilter();
            //ListView is bound in IngredientPicker.xaml
            // listView.ItemsSource = App.Database.GetItems();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.ApplyChanges();
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectedIngredients(ViewModel.GetSelectedIngredients()));
            /*
            //FOR TESTING
            string testString = ViewModel.CreateSearchString();
            Console.WriteLine($"Search string is {testString}");

            await Navigation.PushAsync(new RecipeResults(testString));*/

        }
        private void sb_TextChanged(object sender, EventArgs e)
        {
            ViewModel.ApplyFilter();
        }
    }
}
