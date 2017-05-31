using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Mensarium
{
    [Activity(Label = "Pozovi prijatelja", Theme = "@style/Theme.AppCompat")]
    public class PozoviPrijateljaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PozoviPrijatelja);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.pozoviToolbar);

            toolbar.InflateMenu(Resource.Menu.search);

            toolbar.MenuItemClick += (object sender, Android.Support.V7.Widget.Toolbar.MenuItemClickEventArgs e) =>
            {

            };

            var search = toolbar.Menu.FindItem(Resource.Id.action_search);
            var searchView = search.ActionView.JavaCast<Android.Support.V7.Widget.SearchView>();

        }
    }
}