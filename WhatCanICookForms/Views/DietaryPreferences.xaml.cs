using System;
using System.Collections.Generic;
using WhatCanICookForms.Models;
using WhatCanICookForms.ViewModels;
using WhatCanICookForms.Views;
using Xamarin.Forms;

namespace WhatCanICookForms
{
    public partial class DietaryPreferences : ContentPage
    {
        DietaryPreferencesViewModel ViewModel { get; set; } = new DietaryPreferencesViewModel();

        public DietaryPreferences()
        {
            InitializeComponent();
            BindingContext = ViewModel;
        }
        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        /*
            SearchBox textchanged event handling
            - Call to ApplyFilter which will update the visible items in the list based on the SearchText in the ViewModel.
        */
        private void sb_TextChanged(object sender, EventArgs e)
        {
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
    }
}
