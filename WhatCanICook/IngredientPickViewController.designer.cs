// WARNING
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
    [Register ("IngredientPickViewController")]
    partial class IngredientPickViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField nameIngredient { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton saveButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (nameIngredient != null) {
                nameIngredient.Dispose ();
                nameIngredient = null;
            }

            if (saveButton != null) {
                saveButton.Dispose ();
                saveButton = null;
            }
        }
    }
}