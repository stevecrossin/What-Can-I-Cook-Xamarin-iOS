using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WhatCanICookForms.Models;
using Xamarin.Forms;

namespace WhatCanICookForms.ViewModels
{
    public class PantryViewModel : BaseViewModel
    {
        public PantryViewModel() : base()
        {
            base.AdditionalFilter = itm => !itm.ExcludedBoolean;
        }


        /* Method to create a search string based on selected ingredients
         * @returns string representing the search string
         * - Foreach loop to loop through each selected ingredient in the list
         * - Concatenate each ingredient name to the search string value before returning
         */
        [Obsolete]
        public string CreateSearchString()
        {
            var items = Items.Where(itm => itm.SavedBoolean || itm.ExcludedBoolean);
            return GetSearchString(items);
        }
        public List<Ingredient> GetSelectedIngredients()
        {
            return Items.Where(itm => itm.SavedBoolean || itm.ExcludedBoolean).ToList();
        }
    }
}
