using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace WhatCanICook
{
    public partial class IngredientPickViewController: UIViewController
    {
        public List<IngredientsList> allStudents { get; set; }
        public UIViewController(IntPtr handle) : base(handle)
        {
            allStudents = new List<IngredientsList>();
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            saveButton.TouchUpInside += (object sender, EventArgs e) => {
                IngredientsList newStudent = new IngredientsList(newIngredient.Text); allStudents.Add(newStudent);
                string infoString = "Name: " + newStudent.name + " ID: " + newStudent.id;
                var alert = UIAlertController.Create("New Student Information", infoString, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            };
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }