using System;
using System.Collections.Generic;
using System.Linq;
using WhatCanICookForms.Models;

namespace WhatCanICookForms.ViewModels
{
    public class SelectedIngredientsViewModel : BaseViewModel
    {
        public bool CanRemoveSavedItems { get; set; }
        public SelectedIngredientsViewModel(List<Ingredient> ingredients, bool canRemoveSavedItems = false) : base(ingredients)
        {
            CanRemoveSavedItems = canRemoveSavedItems;
        }

        internal void ClearIngredientStatus(Ingredient ingredient)
        {
            //removing ingredient from Selected, Excluded or Saved.
            //We can remove the ingredients from the pantry only if we arrived here navigating from the pantry view by setting canRemoveSavedItems to true.
            if (ingredient.SelectedBoolean)
                ingredient.SelectedBoolean = false;
            if (ingredient.ExcludedBoolean)
                ingredient.ExcludedBoolean = false;
            if (ingredient.SavedBoolean && CanRemoveSavedItems)
                ingredient.SavedBoolean = false;
            //saving changes to ingredient 
            ApplyChanges(ingredient);
            //reloading visible items based on applied changes
            FilteredItems = Items.Where(itm => (itm.SavedBoolean && CanRemoveSavedItems) || itm.SelectedBoolean || itm.ExcludedBoolean).ToList();
        }

        internal string CreateSearchString()
        {
            return base.GetSearchString(Items);
        }
    }
}
