using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WhatCanICookForms.BaseClasses;
using WhatCanICookForms.Models;
using Xamarin.Forms;

namespace WhatCanICookForms.ViewModels
{
    //MANIPULATE DATA IN INGREDIENT PICKER HERE
    public class IngredientPickerViewModel : BaseViewModel
    {
        //List<Ingredient> selectedIngredients = new List<Ingredient>();



        public IngredientPickerViewModel() : base()
        {
            base.AdditionalFilter = itm => !itm.ExcludedBoolean;
        }

        /*Method to update ingredients user has selected
         * @param - selectedID, type int representing the ingredient ID of the selected ingredient
         * - Call SetIngredientSelected() as part of Ingredient Database to update selected value
         * - Add selected ingredient to list (used to create search string)
         */
        public void UpdateSelectedIngredients(int selectedID)
        {
            App.Database.SetIngredientSelected(App.Database.GetItems(selectedID).ID, 1);
            //selectedIngredients.Add(App.Database.GetItems(selectedID));
        }

        /* Method to create a search string based on selected ingredients
         * @returns string representing the search string
         * - Foreach loop to loop through each selected ingredient in the list
         * - Concatenate each ingredient name to the search string value before returning
         */
        [Obsolete]
        public string CreateSearchString()
        {
            var items = Items.Where(itm => itm.SelectedBoolean || itm.ExcludedBoolean);
            return GetSearchString(items);
        }
        public List<Ingredient> GetSelectedIngredients()
        {
            return Items.Where(itm => itm.SelectedBoolean || itm.ExcludedBoolean).ToList();
        }
    }
}
