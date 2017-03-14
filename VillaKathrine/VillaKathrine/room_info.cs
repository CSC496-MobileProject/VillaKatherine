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

namespace VillaKathrine
{
    [Activity(Label = "room_info")]
    public class room_info : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // This will Hide the title Bar
            Window.RequestFeature(WindowFeatures.NoTitle); 

            // Pull string from previous activity
            String room_id = Intent.GetStringExtra("room_id");

            // Set our view from the "Photos" layout resource
            SetContentView(Resource.Layout.room_info);

            // Set reference to buttons
            Button returnButton = FindViewById<Button>(Resource.Id.return_button);

            // Set reference and value to header
            TextView header = FindViewById<TextView>(Resource.Id.room_name);
            header.Text = room_id;

            TextView desc = FindViewById<TextView>(Resource.Id.room_desc);

            desc.Text = Resources.GetString(Resource.String.parlor);

            // OnClick functions for buttons
            returnButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(rooms));
                StartActivity(intent);
            };

            
        }
    }
}