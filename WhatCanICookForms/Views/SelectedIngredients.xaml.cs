using System;
using System.Collections.Generic;
using WhatCanICookForms.Models;
using WhatCanICookForms.ViewModels;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class SelectedIngredients : ContentPage
    {

        /***********************
                VARIABLES
         **********************/

        SelectedIngredientsViewModel ViewModel { get; set; }

        /***********************
                METHODS
         **********************/

        //Constructor
        public SelectedIngredients(List<Ingredient> selectedIngredients, bool canRemoveSavedItems = false)
        {
            InitializeComponent();
            //create the viewmodel with the list of selectedIngredients and canRemoveSavedItems if we arrived here from the Pantry view.
            ViewModel = new SelectedIngredientsViewModel(selectedIngredients, canRemoveSavedItems);
            BindingContext = ViewModel;
        }

        /*
         * Search Button Click event handling we create the search string from the selected ingredients.
         */
        private async void Search_Clicked(object sender, EventArgs e)
        {
            string searchString = ViewModel.CreateSearchString();
            await Navigation.PushAsync(new RecipeResults(searchString));
        }

        /*
         * Remove Button Click event handling
         * -Take the ingredient from the BindingContext on the button 
         * -Clear it's status by calling ViewModel ClearIngredientStatus
         */
        private void btnRemove_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Ingredient ingredient = (Ingredient)btn.BindingContext;
            ViewModel.ClearIngredientStatus(ingredient);
        }

        /*
            SearchBox textchanged event handling
            - Call to ApplyFilter which will update the visible items in the list based on the SearchText in the ViewModel.
            */
        private void sb_TextChanged(object sender, EventArgs e)
        {
            ViewModel.ApplyFilter();
        }
    }
}
