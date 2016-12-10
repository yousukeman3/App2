using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            TextView label1 = FindViewById<TextView>(Resource.Id.textView1);
            TextView label2 = FindViewById<TextView>(Resource.Id.textView2);
            EditText textbox1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText textbox2 = FindViewById<EditText>(Resource.Id.editText2);

            button1.Click += delegate {
                if (textbox1.Text == "" )
                    textbox1.Text = "0";
                if (textbox2.Text == "")
                    textbox2.Text = "0";
                try
                {
                    label2.Text = "" + (Convert.ToInt64(textbox1.Text) + Convert.ToInt64(textbox2.Text));
                }
                catch
                {
                    label2.Text = "Error";
                }    
            };
        }
    }
}

