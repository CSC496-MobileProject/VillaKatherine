using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace VillaKatherine.Droid
{
    [Activity(Label = "Activity1")]
    public class return_rooms : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            // Set our view from the "parlor" layout resource
            SetContentView(Resource.Layout.parlor);

            // Set reference to buttons
            Button returnButton = FindViewById<Button>(Resource.Id.return_button);

            // OnClick functions for buttons
            returnButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(return_rooms));
                StartActivity(intent);
            };

        }

    }
}