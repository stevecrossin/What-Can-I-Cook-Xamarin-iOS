using System;
using SQLite;

namespace WhatCanICookForms.Models
{

    // THIS IS USED IN THE INGREDIENTDATABASE.CS QUERY
    public class Ingredient
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Excluded { get; set; }
        public int Selected { get; set; }
        public int Saved { get; set; }
    }
}
