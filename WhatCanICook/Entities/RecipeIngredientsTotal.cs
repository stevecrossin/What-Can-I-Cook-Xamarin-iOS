using System;
namespace WhatCanICook.Entities
{
    public class RecipeIngredientsTotal
    {

        /**********************
         VARIABLES
         *********************/

        private int id;
        private String recipeName;
        private int totalIngredients;

        /**********************
         PROPERTIES
         *********************/

        //Properties to expose variables as opposed to getter and setter methods
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String RecipeName
        {
            get { return recipeName; }
            set { recipeName = value; }
        }

        public int TotalIngredients
        {
            get { return totalIngredients; }
            set { totalIngredients = value; }
        }

        /**********************
         METHODS
         *********************/

        //Constructor
        public RecipeIngredientsTotal(String recipeName, int totalIngredients)
        {
            this.recipeName = recipeName;
            this.totalIngredients = totalIngredients;
        }
    }
}
