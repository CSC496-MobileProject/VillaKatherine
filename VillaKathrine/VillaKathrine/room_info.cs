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

            // Set reference to buttons and image view
            Button returnButton = FindViewById<Button>(Resource.Id.return_button);
            ImageView img = FindViewById<ImageView>(Resource.Id.imageview);

            // Set reference and value to header
            TextView header = FindViewById<TextView>(Resource.Id.room_name);
            header.Text = room_id;

            TextView desc = FindViewById<TextView>(Resource.Id.room_desc);

            /*int parlor = (int)typeof(Resource.Drawable).GetField("parlor").GetValue(null);
            int courtyard = (int)typeof(Resource.Drawable).GetField("courtyard").GetValue(null);
            int dining_room = (int)typeof(Resource.Drawable).GetField("dining_room").GetValue(null);
            int sitting_room = (int)typeof(Resource.Drawable).GetField("sitting_room").GetValue(null);
            int bedrooms = (int)typeof(Resource.Drawable).GetField("bedrooms").GetValue(null);*/

            switch (room_id)
            {
                case "Parlor":
                    desc.Text = Resources.GetString(Resource.String.parlor);
                    //img.SetImageResource(parlor);
                    break;
                case "Courtyard":
                    desc.Text = Resources.GetString(Resource.String.courtyard);
                    //img.SetImageResource(courtyard);
                    break;
                case "Dining Room":
                    desc.Text = Resources.GetString(Resource.String.dining_room);
                    //img.SetImageResource(dining_room);
                    break;
                case "Sitting Room":
                    desc.Text = Resources.GetString(Resource.String.sitting_room);
                    //img.SetImageResource(sitting_room);
                    break;
                case "Bedrooms":
                    desc.Text = Resources.GetString(Resource.String.bedrooms);
                    //img.SetImageResource(bedrooms);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            // OnClick functions for buttons
            returnButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(rooms));
                StartActivity(intent);
            };

            
        }
    }
}