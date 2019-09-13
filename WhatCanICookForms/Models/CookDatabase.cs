using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace WhatCanICookForms.Models
{
    public class CookDatabase
    {
        readonly SQLiteAsyncConnection database;

        public CookDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<RecipeItem>().Wait();
        }

        public Task<List<RecipeItem>> GetItemsAsync()
        {
            return database.Table<RecipeItem>().ToListAsync();
        }


        // DATABASE QUERY HERE - uncertain if using correct column heading to show ingredients (using saved; could use selected?)
        public Task<List<RecipeItem>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<RecipeItem>("SELECT * FROM [RecipeItem] WHERE [Saved] = 0");
        }

        public Task<RecipeItem> GetItemsAsync(int id)
        {
            return database.Table<RecipeItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(RecipeItem item)
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

        public Task<int> DeleteItemAsync(RecipeItem item)
        {
            return database.DeleteAsync(item);
        }

    }
}
