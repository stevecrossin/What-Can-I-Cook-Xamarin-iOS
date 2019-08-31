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
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSignup { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView tvLoginDescription { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnSignup != null) {
                btnSignup.Dispose ();
                btnSignup = null;
            }

            if (labelLogin != null) {
                labelLogin.Dispose ();
                labelLogin = null;
            }

            if (tfLogin != null) {
                tfLogin.Dispose ();
                tfLogin = null;
            }

            if (tfPassword != null) {
                tfPassword.Dispose ();
                tfPassword = null;
            }

            if (tvLoginDescription != null) {
                tvLoginDescription.Dispose ();
                tvLoginDescription = null;
            }
        }
    }
}