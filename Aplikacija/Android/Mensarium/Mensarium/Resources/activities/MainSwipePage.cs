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
using Android.Support.V7.View.Menu;
using Mensarium.Components;
using Mensarium.Resources.activities;
using Mensarium.Resources.adapters;
using MensariumDesktop.Model.Components.DTOs;
using Animation = Android.Views.Animations.Animation;
using SearchView = Android.Support.V7.Widget.SearchView;
using View = Android.Views.View;
using System.Threading;

namespace Mensarium
{

    [Activity(Theme = "@style/Theme.MyTheme", Label = "Mensarium")]
    class MainSwipePage : ActionBarActivity
    {
        private TabLayout tabLayout;
        private ViewPager viewPager;
        private List<KorisnikFollowDto> listaPretrage = new List<KorisnikFollowDto>();
        private Android.Widget.ListView listView;
        private LinearLayout layoutPretrage;
        private Android.App.AlertDialog alert;
        private Android.App.AlertDialog alertGreska;

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

            viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = new MainSwipePageAdapter(base.SupportFragmentManager, fragments, titles);

            tabLayout = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            tabLayout.SetupWithViewPager(viewPager);

            layoutPretrage = FindViewById<LinearLayout>(Resource.Id.LayoutZaListuPretrage);
            listView = FindViewById<Android.Widget.ListView>(Resource.Id.listaPretrage);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.bottom_menu, menu);

            var searchItem = menu.FindItem(Resource.Id.search);

            var searchView = MenuItemCompat.GetActionView(searchItem);
            var _searchView = searchView.JavaCast<Android.Support.V7.Widget.SearchView>();

            _searchView.QueryTextChange += (s, e) =>
            {
                if (e.NewText.Equals(String.Empty))
                {
                    tabLayout.Visibility = ViewStates.Visible;
                    viewPager.Visibility = ViewStates.Visible;
                    listView.Adapter = null;
                    layoutPretrage.Visibility = ViewStates.Gone;
                }
                else
                {
                    tabLayout.Visibility = ViewStates.Gone;
                    viewPager.Visibility = ViewStates.Gone;
                    layoutPretrage.Visibility = ViewStates.Visible;
                }
            };

            _searchView.QueryTextSubmit += (s, e) =>
            {
                _searchView.ClearFocus();

                alert = new Android.App.AlertDialog.Builder(this).Create();
                alert.SetTitle("Vrsi se pretraga!");
                alert.SetMessage("Molimo sacekajte!");
                alert.SetCancelable(false);

                alert.Show();

                alertGreska = new Android.App.AlertDialog.Builder(this).Create();
                alertGreska.SetTitle("Pretraga neuspesna!");
                alertGreska.SetMessage("Nije pronadjeno nijedno poklapanje sa: " + e.Query);
                alertGreska.SetButton("U redu", delegate (object sender, DialogClickEventArgs args) { alert.Dismiss(); });

                Thread novaNit = new Thread(() => FuncijaZaNoviNit(e.Query));
                novaNit.Start();

                e.Handled = true;
            };

            return true;
        }

        private void FuncijaZaNoviNit(string s)
        {
            PretragaKriterijumDto pretraga = new PretragaKriterijumDto();
            pretraga.IdKorisnika = MSettings.CurrentSession.LoggedUser.UserID;
            pretraga.Kriterijum = s;

            try
            {
                this.listaPretrage = Api.Api.SearchUsers(pretraga);

                layoutPretrage.Visibility = ViewStates.Visible;

                RunOnUiThread(() => listView.Adapter = new PretragaListAdapter(this, listaPretrage));
                alert.Dismiss();
            }
            catch (Exception ex)
            {
                RunOnUiThread(() => alert.Dismiss());

                RunOnUiThread(() => alertGreska.Show());
            }
        }

        private void ActionView_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            Toast.MakeText(this, "rad", ToastLength.Short).Show();
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
                    return true;

                    //odjava
                case Resource.Id.action_set2:
                    Api.Api.LogoutUser(MSettings.CurrentSession.SessionID);
                    var intent = new Intent(this, typeof(MainActivity));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                    StartActivity(intent);
                    this.Finish();
                    return true;

                case Resource.Id.prijatelji:
                    var intent2 = new Intent(this, typeof(MojiPrijateljiActivity));
                    StartActivity(intent2);
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}