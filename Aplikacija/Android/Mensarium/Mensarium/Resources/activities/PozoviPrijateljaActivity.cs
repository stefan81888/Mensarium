using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Mensarium.Resources.adapters;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium
{
    [Activity(Label = "Pozovi prijatelja", Theme = "@style/Theme.AppCompat")]
    public class PozoviPrijateljaActivity : ActionBarActivity
    {
        private List<KorisnikFollowDto> listaPrijatelja;
        private Android.Support.V7.Widget.SearchView _searchView;
        private ListView _listView;
        private PozoviPrijateljaAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PozoviPrijatelja);

            SupportActionBar.SetDisplayShowHomeEnabled(true);
            
            try
            {
                List<KorisnikFollowDto> listaPrijatelja = Api.Api.UsersThatFollows();
                //FindViewById<ListView>(Resource.Id.listaPrijatelja).Adapter = new PozoviPrijateljaAdapter(this, listaPrijatelja);

                _listView = FindViewById<ListView>(Resource.Id.listaPrijatelja);
                adapter = new PozoviPrijateljaAdapter(this, listaPrijatelja);
                _listView.Adapter = adapter;
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
            }
            
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.search, menu);

            var item = menu.FindItem(Resource.Id.action_search);

            var searchView = MenuItemCompat.GetActionView(item);
            _searchView = searchView.JavaCast<Android.Support.V7.Widget.SearchView>();

            _searchView.QueryTextChange += (s, e) => adapter.Filter.InvokeFilter(e.NewText);

            _searchView.QueryTextSubmit += (s, e) =>
            {
                Toast.MakeText(this, "Searched for: " + e.Query, ToastLength.Short).Show();
                e.Handled = true;
            };

            MenuItemCompat.SetOnActionExpandListener(item, new SearchViewExpandListener(adapter));

            return true;
        }

        private class SearchViewExpandListener
            : Java.Lang.Object, MenuItemCompat.IOnActionExpandListener
        {
            private readonly IFilterable _adapter;

            public SearchViewExpandListener(IFilterable adapter)
            {
                _adapter = adapter;
            }

            public bool OnMenuItemActionCollapse(IMenuItem item)
            {
                _adapter.Filter.InvokeFilter("");
                return true;
            }

            public bool OnMenuItemActionExpand(IMenuItem item)
            {
                return true;
            }
        }
    }
}