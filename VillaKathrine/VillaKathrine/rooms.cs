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
    [Activity(Label = "rooms")]
    public class rooms : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Window.RequestFeature(WindowFeatures.NoTitle); //This will Hide the title Bar

            // Set our view from the "Photos" layout resource
            SetContentView(Resource.Layout.rooms);

            // Set reference to buttons
            Button homeButton = FindViewById<Button>(Resource.Id.home_button);
            Button photosButton = FindViewById<Button>(Resource.Id.photos_button);
            Button roomsButton = FindViewById<Button>(Resource.Id.rooms_button);
            Button timlineButton = FindViewById<Button>(Resource.Id.timeline_button);
            Button parlorButton = FindViewById<Button>(Resource.Id.parlor_button);
            Button courtyardButton = FindViewById<Button>(Resource.Id.courtyard_button);
            Button diningButton = FindViewById<Button>(Resource.Id.dining_button);
            Button sittingButton = FindViewById<Button>(Resource.Id.sitting_button);
            Button bedroomButton = FindViewById<Button>(Resource.Id.bedroom_button);

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

            timelineButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(timeline));
                StartActivity(intent);
            };

            parlorButton.Click += (object sender, EventArgs e) => 
            {
                var intent = new Intent(this, typeof(room_info));
                intent.PutExtra("room_id", "Parlor");
                StartActivity(intent);
            };

            courtyardButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(room_info));
                intent.PutExtra("room_id", "Courtyard");
                StartActivity(intent);
            };

            diningButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(room_info));
                intent.PutExtra("room_id", "Dining Room");
                StartActivity(intent);
            };

            sittingButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(room_info));
                intent.PutExtra("room_id", "Sitting Room");
                StartActivity(intent);
            };

            bedroomButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(room_info));
                intent.PutExtra("room_id", "Bedrooms");
                StartActivity(intent);
            };
        }
    }
}