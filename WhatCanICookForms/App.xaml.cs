using System;
using System.IO;
using Xamarin.Forms;
using WhatCanICookForms.Models;
using WhatCanICookForms.Views;
using System.Linq;

namespace WhatCanICookForms
{
    public partial class App : Application
    {
        /***********************
                VARIABLES
         **********************/

        //Ingredient Database instance
        static IngredientDatabase database;
        //Authentication token
        static string _Token;
        //Declare pages
        public static Page myPage = new MainPage();
        public static NavigationPage NavPage = new NavigationPage(myPage);

        /***********************
                METHODS
         **********************/

        //Constructor
        public App()
        {
            InitializeComponent();
            MainPage = NavPage;
        }

        /*
         * Method to determine successful authentication. Allows user to proceed to main menu by inserting the HomePage at the top of the nav stack
         */
        public static Action SuccessfulLoginAction
        {
            get
            {
                return new Action(() =>
                {
                    NavPage.Navigation.PopModalAsync();
                    NavPage.Navigation.InsertPageBefore(new HomePage(), NavPage.Navigation.NavigationStack.First());
                    NavPage.Navigation.PopToRootAsync();
                });
            }
        }

        /*
         * Method to determine successful authentication. Returns user to login page by inserting the MainPage at the top of the nav stack
         */
        public static Action FailedLoginAction
        {
            get
            {
                return new Action(() =>
                {
                    NavPage.Navigation.PopModalAsync();
                    NavPage.Navigation.InsertPageBefore(new MainPage(), NavPage.Navigation.NavigationStack.First());
                    NavPage.Navigation.PopToRootAsync();
                });
            }
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        /*
         * Method to save the authentication token provided by facebook login
         */
        public static void SaveToken(string token)
        {
            _Token = token;
        }

        //Method to return a local path for storing DB
        public static IngredientDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new IngredientDatabase(
                      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }
    }
}


