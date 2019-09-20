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
        private void sb_TextChanged(object sender, EventArgs e)
        {
            ViewModel.ApplyFilter();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.ApplyChanges();
        }
    }
}
