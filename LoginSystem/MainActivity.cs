using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace LoginSystem
{
    [Activity(Label = "LoginSystem", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button mBtnSignUp;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            mBtnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            mBtnSignUp.Click += (object sender, EventArgs args) =>
              {
                  //Pull up dialog
                  FragmentTransaction transaction = FragmentManager.BeginTransaction();
                  dialog_SignUp signUpDialog = new dialog_SignUp();
                  signUpDialog.Show(transaction, "dialog fragment");
            };
        }
    }
}

