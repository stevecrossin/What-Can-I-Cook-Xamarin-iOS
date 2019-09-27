using Xamarin.Forms;

namespace WhatCanICookForms.Views
{
    public partial class LoginPage : ContentPage

    {
        /***********************
                METHODS
         **********************/

        //Constructor
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
