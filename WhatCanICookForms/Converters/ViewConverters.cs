using System;
using System.Globalization;
using Xamarin.Forms;

namespace WhatCanICookForms.Converters
{
    public class BooleanToIngredientBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool excluded = (bool)value;
            return excluded ? Color.LightCoral : Color.LightGreen;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
