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
using Android.Graphics;
using Android.Provider;
using Android.Database;

namespace VillaKathrine
{
    [Activity(Label = "photo_view")]
    public class photo_view : Activity
    {
        ImageView pickedImage;
        ScaleGestureDetector detector;
        private Matrix matrix = new Matrix();
        private float scale = 1f;

        public void initialize()
        {
            String img_id = Intent.GetStringExtra("img_id");

            pickedImage = (ImageView)FindViewById(Resource.Id.zoomImageView);
            int image = (int)typeof(Resource.Drawable).GetField(img_id).GetValue(null);
            pickedImage.SetImageResource(image);
            detector = new ScaleGestureDetector(this, new Zoomer(this));
        }

        public override bool OnTouchEvent(MotionEvent ev)
        {
            detector.OnTouchEvent(ev);
            return true;
        }

        private class Zoomer : ScaleGestureDetector.SimpleOnScaleGestureListener
        {
            photo_view photo_view;

            public Zoomer(photo_view photo_view)
            {
                this.photo_view = photo_view;
            }
            public override bool OnScale(ScaleGestureDetector detector)
            {
                // TODO Auto-generated method stub
                photo_view.scale *= detector.ScaleFactor;
                photo_view.scale = Math.Max(0.1f, Math.Min(photo_view.scale, 5.0f));

                photo_view.matrix.SetScale(photo_view.scale, photo_view.scale);
                photo_view.pickedImage.ImageMatrix = photo_view.matrix;
                return true;
            }


        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Window.RequestFeature(WindowFeatures.NoTitle); //This will Hide the title Bar

            // Set our view from the "photo_view" layout resource
            SetContentView(Resource.Layout.photo_view);
            initialize();

            // OnClick functions for buttons
            Button returnButton = FindViewById<Button>(Resource.Id.return_button);
            returnButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photos));
                StartActivity(intent);
            };
        }


    }
}