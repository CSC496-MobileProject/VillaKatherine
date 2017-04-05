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
            ImageView imageView7 = FindViewById<ImageView>(Resource.Id.imageView7);
            ImageView imageView8 = FindViewById<ImageView>(Resource.Id.imageView8);
            ImageView imageView9 = FindViewById<ImageView>(Resource.Id.imageView9);
            ImageView imageView10 = FindViewById<ImageView>(Resource.Id.imageView10);
            ImageView imageView11 = FindViewById<ImageView>(Resource.Id.imageView11);
            ImageView imageView12 = FindViewById<ImageView>(Resource.Id.imageView12);
            ImageView imageView13 = FindViewById<ImageView>(Resource.Id.imageView13);
            ImageView imageView14 = FindViewById<ImageView>(Resource.Id.imageView14);
            ImageView imageView15 = FindViewById<ImageView>(Resource.Id.imageView15);
            ImageView imageView16 = FindViewById<ImageView>(Resource.Id.imageView16);
            ImageView imageView17 = FindViewById<ImageView>(Resource.Id.imageView17);
            ImageView imageView18 = FindViewById<ImageView>(Resource.Id.imageView18);
            ImageView imageView19 = FindViewById<ImageView>(Resource.Id.imageView19);
            ImageView imageView20 = FindViewById<ImageView>(Resource.Id.imageView20);
            ImageView imageView21 = FindViewById<ImageView>(Resource.Id.imageView21);
            ImageView imageView22 = FindViewById<ImageView>(Resource.Id.imageView22);
            ImageView imageView23 = FindViewById<ImageView>(Resource.Id.imageView23);
            ImageView imageView24 = FindViewById<ImageView>(Resource.Id.imageView24);
            ImageView imageView25 = FindViewById<ImageView>(Resource.Id.imageView25);

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
                intent.PutExtra("img_id", "sitting_room"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView6.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "parlor"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView7.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "chair"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView8.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "lamp"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView9.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "men"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView10.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "stairs"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView11.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "window"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView12.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "balcony"); //pass image name to photo_view
                StartActivity(intent);
            };
            imageView13.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "chandlier1"); //pass image name to photo_view
                StartActivity(intent);
            };
            imageView14.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "chandliers"); //pass image name to photo_view
                StartActivity(intent);
            };
            imageView15.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "desk"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView16.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "entrance"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView17.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "kitchen"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView18.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "sitting_room1"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView19.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "sitting_room2"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView20.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "trunk"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView21.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "upstairs"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView22.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "villa1"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView23.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "villa2"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView24.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "villa3"); //pass image name to photo_view
                StartActivity(intent);
            };

            imageView25.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photo_view));
                intent.PutExtra("img_id", "villa4"); //pass image name to photo_view
                StartActivity(intent);
            };
        }
    }
}