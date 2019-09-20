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
        DietaryPreferencesViewModel dpvm = new DietaryPreferencesViewModel();

        public DietaryPreferences()
        {
            InitializeComponent();

            //Update selected ingredient
            listView.ItemSelected += (sender, e) =>
            {
                //Null check
                if (e.SelectedItem != null)
                {
                    dpvm.SetDietaryPreferences(e.SelectedItemIndex);

                    //FOR TESTING
                    Console.WriteLine($"{App.Database.GetItems(4).Name} excluded value is {App.Database.GetItems(4).Excluded}");
                }
            };
        }
        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
