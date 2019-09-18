using System;
using System.Collections.Generic;
using WhatCanICookForms.Models;
using Xamarin.Forms;

namespace WhatCanICookForms.ViewModels
{
    //MANIPULATE DATA IN INGREDIENT PICKER HERE
    public class IngredientPickerViewModel
    {
        List<Ingredient> selectedIngredients = new List<Ingredient>();

        public IngredientPickerViewModel()
        {
        }

        /*Method to update ingredients user has selected
         * @param - selectedID, type int representing the ingredient ID of the selected ingredient
         * - Call SetIngredientSelected() as part of Ingredient Database to update selected value
         * - Add selected ingredient to list (used to create search string)
         */
        public void UpdateSelectedIngredients(int selectedID)
        {
            App.Database.SetIngredientSelected(App.Database.GetItems(selectedID).ID, 1);
            selectedIngredients.Add(App.Database.GetItems(selectedID));
        }

        /* Method to create a search string based on selected ingredients
         * @returns string representing the search string
         * - Foreach loop to loop through each selected ingredient in the list
         * - Concatenate each ingredient name to the search string value before returning
         */
        public string CreateSearchString()
        {
            string searchString = "";

            foreach (Ingredient ingredient in selectedIngredients)
            {
                searchString += " " + ingredient.Name;
            }

            return searchString;
        }

    }
}
