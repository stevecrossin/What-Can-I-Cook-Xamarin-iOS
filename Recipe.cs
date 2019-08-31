using System;
namespace WhatCanICook.Entities
{
    public class Recipe
    {

        /**********************
         VARIABLES
         *********************/

        private int recipeId;
        private String recipeName;
        private String recipeImage;
        private String recipeIngredients;
        private String recipeSteps;
        private int recipeExcluded = 0;
        private bool isSaved;
        private bool isCustomed;

        /**********************
         PROPERTIES
         *********************/

        //Properties to expose variables as opposed to getter and setter methods
        public int RecipeID
        {
            set { RecipeID = value; }
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

        public String RecipeIngredients
        {
            get { return recipeIngredients; }
            set { recipeIngredients = value; }
        }

        public String RecipeSteps
        {
            get { return recipeSteps; }
            set { recipeSteps = value; }
        }

        public int RecipeExcluded
        {
            get { return recipeExcluded; }
            set { recipeExcluded = value; }
        }

        public bool IsSaved
        {
            get { return isSaved; }
            set { isSaved = value; }
        }

        public bool IsCustomed
        {
            get { return isCustomed; }
            set { isCustomed = value; }
        }

        /**********************
         METHODS
         *********************/

        //Constructor
        public Recipe(String recipeName, String recipeImage, String recipeIngredients, String recipeSteps)
        {
            this.recipeName = recipeName;
            this.recipeImage = recipeImage;
            this.recipeIngredients = recipeIngredients;
            this.recipeSteps = recipeSteps;
        }
    }
}
