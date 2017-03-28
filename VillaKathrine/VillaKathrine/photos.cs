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
    [Activity(Label = "photos")]
    public class photos : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Window.RequestFeature(WindowFeatures.NoTitle); //This will Hide the title Bar

            // Set our view from the "Photos" layout resource
            SetContentView(Resource.Layout.photos);

            // Set reference to buttons
            Button homeButton = FindViewById<Button>(Resource.Id.home_button);
            Button photosButton = FindViewById<Button>(Resource.Id.photos_button);
            Button roomsButton = FindViewById<Button>(Resource.Id.rooms_button);
            Button timelineButton = FindViewById<Button>(Resource.Id.timeline_button);

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

            // Set reference to imageview
            ImageView imageView1 = FindViewById<ImageView>(Resource.Id.imageView1);
            ImageView imageView2 = FindViewById<ImageView>(Resource.Id.imageView2);
            ImageView imageView3 = FindViewById<ImageView>(Resource.Id.imageView3);
            ImageView imageView4 = FindViewById<ImageView>(Resource.Id.imageView4);
            ImageView imageView5 = FindViewById<ImageView>(Resource.Id.imageView5);
            ImageView imageView6 = FindViewById<ImageView>(Resource.Id.imageView6);

            imageView1.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "villa_main"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView2.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "bedrooms"); //pass image name to photo_view
                StartActivity(intent);
            };
            imageView3.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "courtyard"); //pass image name to photo_view
                StartActivity(intent);
            };
            imageView4.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "dining_room"); //pass image name to photo_view
                StartActivity(intent);
            };
            imageView5.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "parlor"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView6.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "sitting_room"); //pass image name to photo_view
                StartActivity(intent);
            };
        }
    }
}