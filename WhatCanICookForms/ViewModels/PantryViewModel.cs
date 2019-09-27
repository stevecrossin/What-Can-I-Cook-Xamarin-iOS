using System.Collections.Generic;
using System.Linq;
using WhatCanICookForms.Models;

namespace WhatCanICookForms.ViewModels
{
    public class PantryViewModel : BaseViewModel
    {
        /***********************
                METHODS
         **********************/

        //Constructor
        public PantryViewModel() : base()
        {
            //Setting the AdditionalFilter to be used in the BaseViewModel when applying the filters to the Items.
            // We need to exclude the "excluded" items in the pantry view.
            base.AdditionalFilter = itm => !itm.ExcludedBoolean;
        }

        /* Method to create a list of selected ingredients 
         * @returns - List of Ingredient based on ingredients available in the pantry or excluded
         * - filters the Items list to show only the ingredients that are saved or excluded
         */
        public List<Ingredient> GetSelectedIngredients()
        {
            return Items.Where(itm => itm.SavedBoolean || itm.ExcludedBoolean).ToList();
        }
    }
}
