using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using SQLite;
using System.Diagnostics;
using System.Reflection;
using System.IO;

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
            var info = database.GetTableInfo("Ingredient");
            if (!info.Any())
            {
                //Drop table before recreating to ensure no duplicates everytime app is run
                database.DropTable<Ingredient>();
                database.CreateTable<Ingredient>();

                CreateIngredients();
            }
        }

        //Method to return list of ingredients
        public List<Ingredient> GetItems()
        {
            return database.Table<Ingredient>().ToList();
        }


        // DATABASE Queries are here.
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
                item.IsChanged = false;
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

        //Method to update the excluded value of ingredient in table
        public void SetIngredientExcluded(int id, int isExcluded)
        {
            database.Execute("UPDATE [Ingredient] SET Excluded='" + isExcluded + "' WHERE [ID]='" + id + "'");
        }

        //Method to create the ingredients in the DB, called in constructor - very messy
        public void CreateIngredients()
        {
            //load up the shared project assembly 
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(IngredientDatabase)).Assembly;
            //debug only list the available resources
            var assemblies = assembly.GetManifestResourceNames();
            //Load the specified resource from the resources in the assembly into a Stream
            Stream stream = assembly.GetManifestResourceStream("WhatCanICookForms.ingredients.csv");

            //read the csv file and read all the lines 
            using (var sr = new StreamReader(stream))
            {
                while (!sr.EndOfStream)
                {
                    var csvLine = sr.ReadLine();
                    //parse the csvLine and create the ingredient
                    var parts = csvLine.Split(',');
                    var ingredient = new Ingredient();
                    ingredient.Name = parts[0];
                    ingredient.Image = parts[1];
                    //save the ingredient into database
                    SaveItem(ingredient);
                }
            }
        }

    }
}
