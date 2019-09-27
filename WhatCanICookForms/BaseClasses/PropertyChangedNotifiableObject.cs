using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace WhatCanICookForms.BaseClasses
{
    /*
     * Base class to allow changes to properties to be reflected in the UI
     * The UI listens for PropertyChanged event and refreshes the Binding values accordingly.
    */
    public class PropertyChangedNotifiableObject : INotifyPropertyChanged
    {
        /***********************
                VARIABLES
         **********************/

        public event PropertyChangedEventHandler PropertyChanged;

        /***********************
                METHODS
         **********************/

        //Method to facilitate the triggering of PropertyChanged event
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

