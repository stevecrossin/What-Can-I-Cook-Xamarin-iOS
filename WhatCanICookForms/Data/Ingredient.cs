using SQLite;
using WhatCanICookForms.BaseClasses;

namespace WhatCanICookForms.Models
{

    public class Ingredient : PropertyChangedNotifiableObject
    {

        /***********************
          VARIABLES/PROPERTIES
         **********************/

        [PrimaryKey, AutoIncrement] 
        public int ID { get; set; } // Ingredient ID is primary key used in SQLite table, auto incremented
        // Name of ingredient
        public string Name { get; set; }
        // Ingredient image
        public string Image { get; set; }
        // Excluded flag to determine if ingredient is excluded from search
        public int Excluded { get; set; }
        // Property to set value of Excluded and expose the value
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
        // Selected flag to determine if ingredient is included in search
        public int Selected { get; set; }
        // Property to set value of Selected and expose the value
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
        // IsChanged boolean flag
        public bool IsChanged { get; set; }
        // Saved boolean flag to determine if ingredient has been saved in pantry
        public int Saved { get; set; }
        // Property to set value of Saved and expose the value
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

        /***********************
                 METHODS
         **********************/

        /*
         * Method to generate a search string based on boolean flags
         */
        public string GetSearchString()
        {
            return " " + (ExcludedBoolean ? "-\"" + Name + "\"" : Name);
        }
    }
}
