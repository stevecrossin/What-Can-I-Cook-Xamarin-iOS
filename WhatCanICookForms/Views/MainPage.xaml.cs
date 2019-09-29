using System;
using Xamarin.Forms;
using WhatCanICookForms.Views;

namespace WhatCanICookForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer

    public partial class MainPage : ContentPage
    {

        /***********************
                METHODS
         **********************/

        //Constructor
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           
        }
            

            /*
             * Login button click event handling to take users to Login page for authentication
             */
            public void btnLoginClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
            /*To bypass FB login for Testing, change LoginPage to HomePage*/
        }



    }
}
