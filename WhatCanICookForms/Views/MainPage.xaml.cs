using System;
using Xamarin.Forms;
using WhatCanICookForms.Controls;
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
            Label loginLabel = new Label();
            loginLabel.Text = "Login to What Can I Cook";
            loginLabel.HorizontalOptions = LayoutOptions.CenterAndExpand;
            loginLabel.VerticalOptions = LayoutOptions.Start;
            loginLabel.Margin = 50;
            ImageButton fbImage = new ImageButton();
            fbImage.Source = "facebooklogin.png";
            fbImage.Clicked += btnLoginClicked;
            fbImage.Margin = 50;
            fbImage.HorizontalOptions = LayoutOptions.CenterAndExpand;
            fbImage.VerticalOptions = LayoutOptions.CenterAndExpand;

            AdmobControl admobControl = new AdmobControl()

            {
                AdUnitId = AppConstants.BannerId
            };
            admobControl.HorizontalOptions = LayoutOptions.CenterAndExpand;
            admobControl.VerticalOptions = LayoutOptions.EndAndExpand;
           

            Content = new StackLayout()
            {
            Children = { loginLabel, fbImage, admobControl }
             
           };
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
