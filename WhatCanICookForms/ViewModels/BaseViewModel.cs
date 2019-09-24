using System;
using System.Collections.Generic;
using System.Linq;
using WhatCanICookForms.BaseClasses;
using WhatCanICookForms.Models;

namespace WhatCanICookForms.ViewModels
{
    public class BaseViewModel : PropertyChangedNotifiableObject
    {
        public List<Ingredient> Items { get; set; }

        List<Ingredient> _filteredItems = new List<Ingredient>();
        public List<Ingredient> FilteredItems
        {
            get { return _filteredItems; }
            set
            {
                _filteredItems = value;
                OnPropertyChanged();
            }
        }

        string _searchText = "";
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }
        /*
         * AdditionalFilter is used to apply additional/custom filtering on the ingredients to be shown in the views.
         */
        protected Func<Ingredient, bool> AdditionalFilter = itm => true;

        public BaseViewModel()
        {
            Items = App.Database.GetItems();
            FilteredItems = Items;
        }
        /*
         Constructor to enable viewmodels to handle a list of ingredients without loading it from database
             */
        public BaseViewModel(List<Ingredient> ingredients)
        {
            Items = ingredients;
            FilteredItems = Items;
        }
        /*
         Filters the items based on SearchText and AdditionalFilter that may be specified by the ViewModel
             */
        internal void ApplyFilter()
        {
            var items = Items.Where(AdditionalFilter);
            if (SearchText != null && !string.IsNullOrWhiteSpace(SearchText))
                FilteredItems = items.Where(item => item.Name.ToLower().Contains(SearchText.ToLower())).ToList();
            else
                FilteredItems = items.ToList();
        }
        /*
         Persists to database the changes made on the ingredients
             */
        public void ApplyChanges()
        {
            foreach (var item in Items.Where(itm => itm.IsChanged))
            {
                App.Database.SaveItem(item);
            }
        }
        /*
         Save changes made on the specific ingredient
             */
        public void ApplyChanges(Ingredient ingredient)
        {
            App.Database.SaveItem(ingredient);
        }
        /*
         Create Search string from ingredients ordered by excluded items
             */
        public string GetSearchString(IEnumerable<Ingredient> items)
        {
            String searchString = "";
            foreach (Ingredient ingredient in items.OrderBy(itm => itm.ExcludedBoolean))
            {
                searchString += ingredient.GetSearchString();
            }
            return searchString;
        }
    }
}
