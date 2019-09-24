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
            //Setting the AdditionalFilter to be used in the BaseViewModel when applying the filters to the Items.
            // We need to exclude the "excluded" items in the pantry view.
            base.AdditionalFilter = itm => !itm.ExcludedBoolean;
        }

        /* Method to create a list of selected ingredients 
         * @returns a List of Ingredient based on ingredients available in the pantry or excluded
         * - filters the Items list to show only the ingredients that are saved or excluded
         */
        public List<Ingredient> GetSelectedIngredients()
        {
            return Items.Where(itm => itm.SavedBoolean || itm.ExcludedBoolean).ToList();
        }
    }
}
