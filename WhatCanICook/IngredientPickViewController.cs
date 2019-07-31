using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace WhatCanICook
{

    public partial class IngredientPickViewController : UIViewController
    {
        public List<IngredientsListText> AllIngredients { get; set; }
        public IngredientPickViewController(IntPtr handle) : base(handle)
        {
            AllIngredients = new List<IngredientsListText>();
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            saveButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                IngredientsListText newIngredient = new IngredientsListText(nameIngredient.Text); AllIngredients.Add(newIngredient);
                string infoString = "Name: " + newIngredient.ingredientName;
                var alert = UIAlertController.Create("Saved Ingredient:", infoString, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            };
        }
    }
}

        
    
