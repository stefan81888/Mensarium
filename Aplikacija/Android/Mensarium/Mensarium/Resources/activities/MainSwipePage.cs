using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Xamarin.Forms;
using Android.Support.V7.App;
using Mensarium.Components;

namespace Mensarium
{

    [Activity(Theme = "@style/Theme.MyTheme", Label = "Mensarium")]
    class MainSwipePage : ActionBarActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MainSwipePage);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            var textToolbar = toolbar.FindViewById<TextView>(Resource.Id.toolbar_title);

            SetSupportActionBar(toolbar);
            textToolbar.Text = "Mensarium";

            SupportActionBar.SetDisplayShowTitleEnabled(false);

            //SupportActionBar.SetDisplayShowHomeEnabled(true);
            //SupportActionBar.SetLogo(Resource.Drawable.ActionBarIcon);
            //SupportActionBar.SetDisplayUseLogoEnabled(true);

            var fragments = new Android.Support.V4.App.Fragment[]
                {
                    new ProfilFragment(),
                    new NewsFragment(), 
                    new EventsFragment(), 
                };

            var titles = CharSequence.ArrayFromStringArray(new[]
                {
                    "Profil",
                    "Novosti",
                    "Pozivanja",
                });

            var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);

            viewPager.Adapter = new MainSwipePageAdapter(base.SupportFragmentManager, fragments, titles);

            TabLayout tabLayout = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            tabLayout.SetupWithViewPager(viewPager);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.bottom_menu, menu);

            

            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                //search
                case Resource.Id.action_search:
                    Toast.MakeText(this, "Search", ToastLength.Short).Show();
                    return true;

                    //odjava
                case Resource.Id.action_set2:
                    Api.Api.LogoutUser(MSettings.CurrentSession.SessionID);
                    var intent = new Intent(this, typeof(MainActivity));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                    StartActivity(intent);
                    this.Finish();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}