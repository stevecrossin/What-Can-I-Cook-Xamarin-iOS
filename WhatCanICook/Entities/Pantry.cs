using System;
namespace WhatCanICook.Entities
{
    public class Pantry
    {

        /**********************
         VARIABLES
         *********************/

        private int ingredientID;

        /**********************
         PROPERTIES
         *********************/

        //Properties to expose variables as opposed to getter and setter methods
        public int IngredientID
        {
            get { return ingredientID; }
            set { ingredientID = value; }
        }

        /**********************
         METHODS
         *********************/

        //Constructor
        public Pantry(int ingredientID)
        {
            this.ingredientID = ingredientID;
        }
    }
}
