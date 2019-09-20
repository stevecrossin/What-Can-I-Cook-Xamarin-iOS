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
       protected Func<Ingredient, bool> AdditionalFilter = itm => true;

        public BaseViewModel()
        {
            Items = App.Database.GetItems();
            FilteredItems = Items;
        }
        public BaseViewModel(List<Ingredient> ingredients)
        {
            Items = ingredients;
            FilteredItems = Items;
        }
        internal void ApplyFilter()
        {
            var items = Items.Where(AdditionalFilter);
            if (SearchText != null && !string.IsNullOrWhiteSpace(SearchText))
                FilteredItems = items.Where(item => item.Name.ToLower().Contains(SearchText.ToLower())).ToList();
            else
                FilteredItems = items.ToList();
        }
        public void ApplyChanges()
        {
            foreach (var item in Items.Where(itm => itm.IsChanged))
            {
                App.Database.SaveItem(item);
            }
        }
        public void ApplyChanges(Ingredient ingredient)
        {
            App.Database.SaveItem(ingredient);
        }

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
