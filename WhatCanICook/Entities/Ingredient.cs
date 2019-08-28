using System;
namespace WhatCanICook.Entities
{
    public class Ingredient
    {

        /**********************
         VARIABLES
         *********************/

        private int ingredientID;
        private String ingredientCategory;
        private String categoryIconName;
        private String ingredientSubCat;
        private String ingredientName;
        private String ingredientAlternative;
        private bool ingredientExcluded = false;
        private bool ingredientSelected = false;

        /**********************
         PROPERTIES
         *********************/

         //Properties to expose variables as opposed to getter and setter methods
        public int IngredientID
        {
            set { ingredientID = value; }
        }

        public String IngredientCategory
        {
            get { return ingredientCategory; }
            set { ingredientCategory = value; }
        }

        public String CategoryIconName
        {
            get { return categoryIconName; }
            set { categoryIconName = value; }
        }

        public String IngredientSubCat
        {
            get { return ingredientSubCat; }
            set { ingredientSubCat = value; }
        }

        public String IngredientName
        {
            get { return ingredientName; }
            set { ingredientName = value; }
        }

        public String IngredientAlternative
        {
            get { return ingredientAlternative; }
            set { ingredientAlternative = value; }
        }

        public bool IngredientExcluded
        {
            get { return ingredientExcluded; }
            set { ingredientExcluded = value; }
        }

        public bool IngredientSelected
        {
            get { return ingredientSelected; }
            set { ingredientSelected = value; }
        }

        /**********************
         METHODS
         *********************/

        //Constructor
        public Ingredient(int ingredientID, String ingredientCategory, String categoryIconName, String ingredientSubCat, String ingredientName, String ingredientAlternative)
        {
            this.ingredientID = ingredientID;
            this.ingredientCategory = ingredientCategory;
            this.categoryIconName = categoryIconName;
            this.ingredientSubCat = ingredientSubCat;
            this.ingredientName = ingredientName;
            this.ingredientAlternative = ingredientAlternative;
        }
    }
}
