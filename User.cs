using System;
namespace WhatCanICook.Entities
{
    public class User
    {
        /**********************
         VARIABLES
         *********************/

        private int userID;
        private String userName;
        private String passKey;
        private String intolerances;
        private bool isLoggedIn;
        private String savedIngredients;

        /**********************
         PROPERTIES
         *********************/

        //Properties to expose variables as opposed to getter and setter methods
        public int UsedID
        {
            get { return userID; }
            set { userID = value; }
        }

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public String PassKey
        {
            get { return passKey; }
            set { passKey = value; }
        }

        public String Intolerances
        {
            get { return intolerances; }
            set { intolerances = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        public String SavedIngredients
        {
            get { return savedIngredients; }
            set { savedIngredients = value; }
        }

        /**********************
         METHODS
         *********************/

        //Constructor
        public User(String userName, String passKey)
        {
            this.userName = userName;
            this.passKey = passKey;
            this.isLoggedIn = false;
            this.intolerances = "[]";
            this.savedIngredients = "[]";
        }
    }
}
