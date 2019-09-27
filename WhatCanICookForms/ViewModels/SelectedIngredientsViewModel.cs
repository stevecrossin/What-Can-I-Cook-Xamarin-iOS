using System.Collections.Generic;
using System.Linq;
using WhatCanICookForms.Models;

namespace WhatCanICookForms.ViewModels
{
    public class SelectedIngredientsViewModel : BaseViewModel
    {

        /***********************
                VARIABLES
         **********************/

        //Bool property to determine removal of saved/selected ingredients
        public bool CanRemoveSavedItems { get; set; }

        /***********************
                METHODS
         **********************/

        //Constructor
        public SelectedIngredientsViewModel(List<Ingredient> ingredients, bool canRemoveSavedItems = false) : base(ingredients)
        {
            CanRemoveSavedItems = canRemoveSavedItems;
        }

        /*
         * Method to clear/reset the selected ingredient status/relevant boolean flags
         */
        internal void ClearIngredientStatus(Ingredient ingredient)
        {
            // Removing ingredient from Selected, Excluded or Saved.
            // We can remove the ingredients from the pantry only if we arrived here navigating from the pantry view by setting canRemoveSavedItems to true.
            if (ingredient.SelectedBoolean)
                ingredient.SelectedBoolean = false;
            if (ingredient.ExcludedBoolean)
                ingredient.ExcludedBoolean = false;
            if (ingredient.SavedBoolean && CanRemoveSavedItems)
                ingredient.SavedBoolean = false;

            //Saving changes to ingredient 
            ApplyChanges(ingredient);

            //Reloading visible items based on applied changes
            FilteredItems = Items.Where(itm => (itm.SavedBoolean && CanRemoveSavedItems) || itm.SelectedBoolean || itm.ExcludedBoolean).ToList();
        }

        /*
         * Method to create a search string based off a list of included and excluded ingredients. 
         */
        internal string CreateSearchString()
        {
            return base.GetSearchString(Items);
        }
    }
}
