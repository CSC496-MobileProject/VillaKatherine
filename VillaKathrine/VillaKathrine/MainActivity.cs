using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace VillaKathrine
{
    [Activity(Label = "VillaKathrine", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Window.RequestFeature(WindowFeatures.NoTitle); //This will Hide the title Bar

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Set reference to buttons
            Button homeButton = FindViewById<Button>(Resource.Id.home_button);
            Button photosButton = FindViewById<Button>(Resource.Id.photos_button);
            Button roomsButton = FindViewById<Button>(Resource.Id.rooms_button);
            Button vrButton = FindViewById<Button>(Resource.Id.vr_button);

            // OnClick functions for buttons
            homeButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            photosButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photos));
                StartActivity(intent);
            };

            roomsButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(rooms));
                StartActivity(intent);
            };

            vrButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(vr));
                StartActivity(intent);
            };
        }
    }
}

