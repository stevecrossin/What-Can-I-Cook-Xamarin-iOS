using System;
using Xamarin.Forms;

namespace WhatCanICookForms
{
    public static class AppConstants
    {
        public static string BannerId
        {

            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-3940256099942544/6300978111";
                    case Device.iOS:
                        return "ca-app-pub-3940256099942544/2934735716";
                    default:
                        return "ca-app-pub-3940256099942544/6300978111";
                }
            }
        }
    }
}