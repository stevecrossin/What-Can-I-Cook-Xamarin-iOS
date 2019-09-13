using System;
using SQLite;

namespace WhatCanICookForms.Models
{

    // THIS IS USED IN THE COOKDATABASE.CS QUERY
    public class RecipeItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public bool Excluded { get; set; }
        public bool Selected { get; set; }
        public bool Saved { get; set; }
    }
}
