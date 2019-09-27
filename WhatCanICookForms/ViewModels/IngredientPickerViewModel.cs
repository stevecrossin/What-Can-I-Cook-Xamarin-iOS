using System.Collections.Generic;
using System.Linq;
using WhatCanICookForms.Models;

namespace WhatCanICookForms.ViewModels
{
    public class IngredientPickerViewModel : BaseViewModel
    {

        /***********************
                METHODS
         **********************/

        //Constructor
        public IngredientPickerViewModel() : base()
        {
            //additional filter to hide the excluded items when applying filtering
            base.AdditionalFilter = itm => !itm.ExcludedBoolean;
        }

        /* Method to create a list of selected ingredients 
         * @returns - List of Ingredient based on ingredients selection or exclusion
         * - filters the Items list to show only the ingredients that are selected or excluded
         */
        public List<Ingredient> GetSelectedIngredients()
        {
            return Items.Where(itm => itm.SelectedBoolean || itm.ExcludedBoolean).ToList();
        }
    }
}
