using System;
namespace WhatCanICook.Entities
{
    public class Intolerance
    {

        /**********************
         VARIABLES
         *********************/

        private int intoleranceID;
        private String intoleranceName;
        private String ingredientName;
        private bool intoleranceSelected;

        /**********************
         PROPERTIES
         *********************/

        //Properties to expose variables as opposed to getter and setter methods

        public int IntoleranceID
        {
            set { intoleranceID = value; }
        }

        public String IntoleranceName
        {
            get { return intoleranceName; }
            set { intoleranceName = value; }
        }

        public String IngredientName
        {
            get { return ingredientName; }
            set { ingredientName = value; }
        }

        public bool IntoleranceSelected
        {
            get { return intoleranceSelected; }
            set { intoleranceSelected = value; }
        }

        /**********************
         METHODS
         *********************/

        //Constructor
        public Intolerance(String intoleranceName, String ingredientName)
        {
            this.intoleranceName = intoleranceName;
            this.ingredientName = ingredientName;
            this.intoleranceSelected = false;
        }
    }
}
