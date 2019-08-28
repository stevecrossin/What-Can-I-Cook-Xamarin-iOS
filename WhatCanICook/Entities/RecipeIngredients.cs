using System;
namespace WhatCanICook.Entities
{
    public class RecipeIngredients
    {

        /**********************
         VARIABLES
         *********************/

        private int id;
        private String recipeName;
        private String recipeImage;
        private String ingredients;

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

        public String RecipeImage
        {
            get { return recipeImage; }
            set { recipeImage = value; }
        }

        public String Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        /**********************
         METHODS
         *********************/

        //Constructor
        public RecipeIngredients(String recipeName, String recipeImage, String ingredients)
        {
            this.recipeName = recipeName;
            this.recipeImage = recipeImage;
            this.ingredients = ingredients;
        }
    }
}
