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
    [Activity(Label = "timeline")]
    public class timeline : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Window.RequestFeature(WindowFeatures.NoTitle); //This will Hide the title Bar

            // Set our view from the "Photos" layout resource
            SetContentView(Resource.Layout.timeline);

            // Set reference to buttons
            Button homeButton = FindViewById<Button>(Resource.Id.home_button);
            Button photosButton = FindViewById<Button>(Resource.Id.photos_button);
            Button roomsButton = FindViewById<Button>(Resource.Id.rooms_button);
            Button timelineButton = FindViewById<Button>(Resource.Id.timeline_button);
            Button gmButton = FindViewById<Button>(Resource.Id.george_metz);
            Button timeline_infoButton = FindViewById<Button>(Resource.Id.timeline_info);

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

            gmButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(timeline_info));
                intent.PutExtra("info_id", "George Metz, Eccentric or Visionary?");
                StartActivity(intent);
            };

            timeline_infoButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(timeline_info));
                intent.PutExtra("info_id", "Timeline of Events");
                StartActivity(intent);
            };
        }
    }
}