using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
namespace WhatCanICook
{
    public partial class ShowAllInfoController : UITableViewController
    {
        public List<AllIngredientsList> allStudents { get; set; }
        ///---------
        static NSString allStudentCellId = new NSString("allStudentCell");
        public ShowAllInfoController(IntPtr handle) : base(handle)
        {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), allStudentCellId);
            TableView.Source = new AllStudentDataSource(this);
            allStudents = new List<AllIngredientsList>();
        }
        class AllStudentDataSource : UITableViewSource
        {
            ShowAllInfoController controller;
            public AllStudentDataSource(ShowAllInfoController controller)
            {
                this.controller = controller;
            }
            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return controller.allStudents.Count;
            }
            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell =
                tableView.DequeueReusableCell(ShowAllInfoController.allStudentCellId);
                int row = indexPath.Row;
                cell.TextLabel.Text = controller.allStudents[row].ingredientName;
                return cell;
            }
        }
    }
}