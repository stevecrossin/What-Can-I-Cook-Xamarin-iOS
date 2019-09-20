using System;
using SQLite;
using WhatCanICookForms.BaseClasses;

namespace WhatCanICookForms.Models
{

    // THIS IS USED IN THE INGREDIENTDATABASE.CS QUERY
    public class Ingredient : PropertyChangedNotifiableObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public int Excluded { get; set; }
        public bool ExcludedBoolean
        {
            get { return Excluded == 1; }
            set
            {
                Excluded = value ? 1 : 0;
                IsChanged = true;
                OnPropertyChanged();
            }
        }
        public int Selected { get; set; }
        public bool SelectedBoolean
        {
            get { return Selected == 1; }
            set
            {
                Selected = value ? 1 : 0;
                IsChanged = true;
                OnPropertyChanged();
            }
        }
        public bool IsChanged { get; set; }

        public int Saved { get; set; }
        public bool SavedBoolean
        {
            get { return Saved == 1; }
            set
            {
                Saved = value ? 1 : 0;
                IsChanged = true;
                OnPropertyChanged();
            }
        }

        public string GetSearchString()
        {
            return " " + (ExcludedBoolean ? "-\"" + Name + "\"" : Name);
        }
    }
}
