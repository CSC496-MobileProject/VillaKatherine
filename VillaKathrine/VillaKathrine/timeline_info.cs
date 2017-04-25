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
    [Activity(Label = "timeline_info")]
    public class timeline_info : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Window.RequestFeature(WindowFeatures.NoTitle); //This will Hide the title Bar

            // Set our view from the "Photos" layout resource
            SetContentView(Resource.Layout.timeline_info);

            Button returnButton = FindViewById<Button>(Resource.Id.return_button);

            // Pull string from previous activity
            String info_id = Intent.GetStringExtra("info_id");

            // Set reference and value to header
            TextView header = FindViewById<TextView>(Resource.Id.info_name);
            header.Text = info_id;

            TextView desc = FindViewById<TextView>(Resource.Id.info_desc);

            switch (info_id)
            {
                case "George Metz, Eccentric or Visionary?":
                    desc.Text = Resources.GetString(Resource.String.george_metz);
                    break;
                case "Timeline of Events":
                    desc.Text = Resources.GetString(Resource.String.Timeline_info);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            returnButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(timeline));
                StartActivity(intent);
            };
        }
    }
}