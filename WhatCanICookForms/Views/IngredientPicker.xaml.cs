using System;
using System.Collections.Generic;
using WhatCanICookForms.Models;
using WhatCanICookForms.ViewModels;
using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class IngredientPicker : ContentPage
    {
        IngredientPickerViewModel ViewModel { get; set; } = new IngredientPickerViewModel();

        public IngredientPicker()
        {
            InitializeComponent();
            BindingContext = ViewModel;
        }

        /*
            OnAppearing override to apply the filters on the ingredients when the view is about to be shown.
            */
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.ApplyFilter();
        }
        /*
            OnDisappearing override to apply the changes on the ingredients when navigating away.
            */
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.ApplyChanges();
        }
        /*
            Search button Click event handling
            - Navigate to SelectedIngredients view with the ingredients provided by ViewModel.GetSelectedIngredients method
             */
        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectedIngredients(ViewModel.GetSelectedIngredients()));
        }

        /*
            SearchBox textchanged event handling
            - Call to ApplyFilter which will update the visible items in the list based on the SearchText in the ViewModel.
            */
        private void sb_TextChanged(object sender, EventArgs e)
        {
            ViewModel.ApplyFilter();
        }
    }
}
