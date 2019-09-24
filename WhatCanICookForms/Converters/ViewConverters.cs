using System;
using System.Globalization;
using Xamarin.Forms;

namespace WhatCanICookForms.Converters
{
    /*
     * IValueConverters are used in Xaml Bindings to convert values 
     * Use value converters to avoid putting UI specific logic in the ViewModel.
     * In this case we convert from boolean to Color
     * ExcludedBoolean is true when the ingredient has to be excluded from the recipe
     */
    public class BooleanToIngredientBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool excluded = (bool)value;
            //convert a boolean value to a color
            var ExcludedItemColor = Color.LightCoral;
            var AcceptedItemColor = Color.LightGreen;
        
            return excluded ? ExcludedItemColor : AcceptedItemColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
