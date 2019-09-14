using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace WhatCanICookForms.Models
{
    public class IngredientDatabase
    {

        /***********************
                VARIABLES
         **********************/

        //DB variable - readonly
        readonly SQLiteAsyncConnection database;

        /***********************
             METHODS/QUERIES
         **********************/

        //Constructor
        public IngredientDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Ingredient>().Wait();
        }

        //Method to return list of ingredients
        public Task<List<Ingredient>> GetItemsAsync()
        {
            return database.Table<Ingredient>().ToListAsync();
        }


        // DATABASE QUERY HERE - uncertain if using correct column heading to show ingredients (using saved; could use selected?)
        public Task<List<Ingredient>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Ingredient>("SELECT * FROM [Ingredient] WHERE [Saved] = 0");
        }

        //Method to return ingredient based on ID
        public Task<Ingredient> GetItemsAsync(int id)
        {
            return database.Table<Ingredient>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        //Method to update table with new or modified ingredient
        public Task<int> SaveItemAsync(Ingredient item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        //Method to remove ingredient from table
        public Task<int> DeleteItemAsync(Ingredient item)
        {
            return database.DeleteAsync(item);
        }

    }
}
