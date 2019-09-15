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

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
