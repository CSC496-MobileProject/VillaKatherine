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
using Android.Webkit;

namespace VillaKathrine
{
    [Activity(Label = "photo_view")]
    public class photo_view : Activity
    {
        WebView web_view;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // This will Hide the title Bar
            Window.RequestFeature(WindowFeatures.NoTitle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.photo_view);

            Button returnButton = FindViewById<Button>(Resource.Id.return_button);

            // Pull string from previous activity
            String img_id = Intent.GetStringExtra("img_id");

            web_view = FindViewById<WebView>(Resource.Id.webView);
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("file:///android_asset/" + img_id + ".html");
            web_view.Settings.BuiltInZoomControls = true;
            web_view.Settings.DisplayZoomControls = false;

            returnButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(photos));
                StartActivity(intent);
            };
        }
    }
}