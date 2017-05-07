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

            var fragments = new Android.Support.V4.App.Fragment[]
                {
                    new ProfilFragment(),
                    new NewsFragment(), 
                    new EventsFragment(), 
                    new OptionsFragment(), 
                };

            var titles = CharSequence.ArrayFromStringArray(new[]
                {
                    "Profil",
                    "Novosti",
                    "Pozivanja",
                    "Opcije"
                });

            var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);

            viewPager.Adapter = new MainSwapPageAdapter(base.SupportFragmentManager, fragments, titles);

            TabLayout tabLayout = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            tabLayout.SetupWithViewPager(viewPager);
        }
    }
}