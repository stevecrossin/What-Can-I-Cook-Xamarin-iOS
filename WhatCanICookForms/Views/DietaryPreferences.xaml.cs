using System;
using WhatCanICookForms.ViewModels;
using WhatCanICookForms.Views;
using Xamarin.Forms;

namespace WhatCanICookForms
{
    public partial class DietaryPreferences : ContentPage
    {

        /***********************
                VARIABLES
         **********************/

        DietaryPreferencesViewModel ViewModel { get; set; } = new DietaryPreferencesViewModel();

        /***********************
                METHODS
         **********************/

        //Constructor
        public DietaryPreferences()
        {
            InitializeComponent();
            BindingContext = ViewModel;
        }

        /*
         * Button clicked event handler to take users back to main menu/home page
         */
        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        /*
         * SearchBox textchanged event handling
         * - Call to ApplyFilter which will update the visible items in the list based on the SearchText in the ViewModel.
         */
        private void sb_TextChanged(object sender, EventArgs e)
        {
            ViewModel.ApplyFilter();
        }

        /*
         * OnDisappearing override to apply the changes on the ingredients when navigating away from current screen.
         */
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.ApplyChanges();
        }
    }
}
