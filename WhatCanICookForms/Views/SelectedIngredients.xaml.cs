using System;
using System.Collections.Generic;
using WhatCanICookForms.Models;
using WhatCanICookForms.ViewModels;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class SelectedIngredients : ContentPage
    {
        SelectedIngredientsViewModel ViewModel { get; set; }

        public SelectedIngredients(List<Ingredient> selectedIngredients, bool canRemoveSavedItems = false)
        {
            InitializeComponent();
            ViewModel = new SelectedIngredientsViewModel(selectedIngredients,canRemoveSavedItems);
            BindingContext = ViewModel;

            //FOR TESTING
            Ingredient testIngredient = App.Database.GetItems(3);
            Console.WriteLine($"{testIngredient.Name} selected value is {testIngredient.Selected}");
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            //Perform search based on string passed and push to results
            string testString = ViewModel.CreateSearchString();
            Console.WriteLine($"Search string is {testString}");

            await Navigation.PushAsync(new RecipeResults(testString));

        }
        private void btnRemove_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Ingredient ingredient = (Ingredient)btn.BindingContext;
            ViewModel.ClearIngredientStatus(ingredient);
        }

        private void sb_TextChanged(object sender, EventArgs e)
        {
            ViewModel.ApplyFilter();
        }
    }
}
