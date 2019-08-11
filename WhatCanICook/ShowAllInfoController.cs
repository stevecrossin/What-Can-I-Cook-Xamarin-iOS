using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
namespace WhatCanICook
{
    public partial class ShowAllInfoController : UITableViewController
    {
        public List<AllIngredientsList> allIngredients { get; set; }
        ///---------
        static NSString allIngredientCells = new NSString("allIngredientsCell");
        public ShowAllInfoController(IntPtr handle) : base(handle)
        {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), allIngredientCells);
            TableView.Source = new AllIngredientsDataSource(this);
            allIngredients = new List<AllIngredientsList>();
        }
        class AllIngredientsDataSource : UITableViewSource
        {
            ShowAllInfoController controller;
            public AllIngredientsDataSource(ShowAllInfoController controller)
            {
                this.controller = controller;
            }
            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return controller.allIngredients.Count;
            }
            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell =
                tableView.DequeueReusableCell(ShowAllInfoController.allIngredientCells);
                int row = indexPath.Row;
                cell.TextLabel.Text = controller.allIngredients[row].ingredientName;
                return cell;
            }
        }
    }
}