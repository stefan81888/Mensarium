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
using MensariumDesktop.Model.Components.DTOs;

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
                //novi post
                case Resource.Id.novipost:
                    var inflater = LayoutInflater.From(this);
                    var view = inflater.Inflate(Resource.Layout.noviPostDialog, null);

                    var dialog = new Android.Support.V7.App.AlertDialog.Builder(this);
                    dialog.SetView(view);

                    dialog.SetPositiveButton("Kreiraj", (sender, args) =>
                    {
                        ObjavaCUDto objava = new ObjavaCUDto() { IdLokacije = 1, TekstObjave = view.FindViewById<EditText>(Resource.Id.dialogTextPost).Text};
                        Api.Api.UserNewPost(MSettings.CurrentSession.LoggedUser.UserID, objava);
                    });

                    dialog.SetNegativeButton("Otkazi", (sender, args) => { dialog.Dispose();});

                    dialog.Show();

                    return true;

                //search
                case Resource.Id.search:
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