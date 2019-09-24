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
        public IngredientPickerViewModel() : base()
        {
            //additional filter to hide the excluded items when applying filtering
            base.AdditionalFilter = itm => !itm.ExcludedBoolean;
        }

        /* Method to create a list of selected ingredients 
         * @returns a List of Ingredient based on ingredients selection or exclusion
         * - filters the Items list to show only the ingredients that are selected or excluded
         */
        public List<Ingredient> GetSelectedIngredients()
        {
            return Items.Where(itm => itm.SelectedBoolean || itm.ExcludedBoolean).ToList();
        }
    }
}
