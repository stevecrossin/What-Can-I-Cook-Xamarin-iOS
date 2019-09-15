using System;
using System.IO;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WhatCanICookForms.Models;

namespace WhatCanICookForms
{
    public partial class App : Application
    {
        //Ingredient Database instance
        static IngredientDatabase database;
        static string _Token;
        public static Page myPage = new MainPage();
        public static NavigationPage NavPage = new NavigationPage(myPage);
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static Action SuccessfulLoginAction
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

        public static void SaveToken(string token)
        {
            _Token = token;
        }


        //Read-only property to return a local path for storing DB
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


