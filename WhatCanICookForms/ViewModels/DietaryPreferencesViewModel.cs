using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WhatCanICookForms.Models;
using Xamarin.Forms;

namespace WhatCanICookForms.ViewModels
{
    public class DietaryPreferencesViewModel
    {
        //Bool variables used to remember use - Static to ensure they persist after view change
        public static bool noMeat = false;
        public static bool noDairy = false;
        public static bool noEggs = false;

        public DietaryPreferencesViewModel()
        {
        }

        /* Method to set dietary preferences/excluded value of ingredients
         * @param - index, representing the item in the list view that has been selected
         * - Case statement which is based on index value.
         * - Checks whether intolerance category is currently set to true or false
         * - Calls SetIngredientExcluded DB method based on the bool value checked.
         */
        public void SetDietaryPreferences(int index)
        {
            switch(index)
            {
                //No Meat
                case 0:
                    if (noMeat == false)
                    {
                        App.Database.SetIngredientExcluded(App.Database.GetItems(4).ID, 1);
                        noMeat = true;
                    }
                    else
                    {
                        App.Database.SetIngredientExcluded(App.Database.GetItems(4).ID, 0);
                        noMeat = false;
                    }
                    break;

                //No Dairy
                case 1:
                    //Nothing to edit yet
                    break;

                //No Eggs
                case 2:
                    if (noEggs == false)
                    {
                        App.Database.SetIngredientExcluded(App.Database.GetItems(2).ID, 1);
                        noEggs = true;
                    }
                    else
                    {
                        App.Database.SetIngredientExcluded(App.Database.GetItems(2).ID, 0);
                        noEggs = false;
                    }
                    break;

            }

        }
    }
}
