﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WhatCanICook
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DietNeeds { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Pantry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PickIngredients { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DietNeeds != null) {
                DietNeeds.Dispose ();
                DietNeeds = null;
            }

            if (Pantry != null) {
                Pantry.Dispose ();
                Pantry = null;
            }

            if (PickIngredients != null) {
                PickIngredients.Dispose ();
                PickIngredients = null;
            }
        }
    }
}