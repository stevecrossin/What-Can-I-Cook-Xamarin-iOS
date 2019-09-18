using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using SQLite;

namespace WhatCanICookForms.Models
{
    public class IngredientDatabase
    {

        /***********************
                VARIABLES
         **********************/

        //DB variable - readonly
        readonly SQLiteConnection database;

        /***********************
             METHODS/QUERIES
         **********************/

        //Constructor
        public IngredientDatabase(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            //Drop table before recreating to ensure no duplicates everytime app is run
            database.DropTable<Ingredient>();
            database.CreateTable<Ingredient>();

            CreateIngredients();
        }

        //Method to return list of ingredients
        public List<Ingredient> GetItems()
        {
            return database.Table<Ingredient>().ToList();
        }


        // DATABASE QUERY HERE - uncertain if using correct column heading to show ingredients (using saved; could use selected?)
        public List<Ingredient> GetItemsNotDone()
        {
            return database.Query<Ingredient>("SELECT * FROM [Ingredient] WHERE [Saved] = 0");
        }

        //Method to return ingredient based on ID
        public Ingredient GetItems(int id)
        {
            return database.Table<Ingredient>().FirstOrDefault(ingredient => ingredient.ID == id);
        }

        //Method to update table with new or modified ingredient
        public int SaveItem(Ingredient item)
        {
            if (item.ID != 0)
            {
                return database.Update(item);
            }
            else
            {
                return database.Insert(item);
            }
        }

        //Method to remove ingredient from table
        public int DeleteItem(Ingredient item)
        {
            return database.Delete(item);
        }

        //Method to update the selected value of ingredient in table
        public void SetIngredientSelected(int id, int isSelected)
        {
            database.Execute("UPDATE [Ingredient] SET Selected='" + isSelected + "' WHERE [ID]='" + id + "'");
        }

        //Method to create the ingredients in the DB, called in constructor - very messy
        public void CreateIngredients()
        {
            var apple = new Ingredient();
            var eggs = new Ingredient();
            var broccoli = new Ingredient();
            var chicken = new Ingredient();
            var onion = new Ingredient();
            apple.Name = "Apple";
            eggs.Name = "Eggs";
            broccoli.Name = "Broccoli";
            chicken.Name = "Chicken";
            onion.Name = "Onion";

            List<Ingredient> ingredientsToAdd = new List<Ingredient>();
            ingredientsToAdd.Add(apple);
            ingredientsToAdd.Add(eggs);
            ingredientsToAdd.Add(broccoli);
            ingredientsToAdd.Add(chicken);
            ingredientsToAdd.Add(onion);

            foreach (Ingredient ingredient in ingredientsToAdd)
            {
                SaveItem(ingredient);
            }
        }

    }
}
