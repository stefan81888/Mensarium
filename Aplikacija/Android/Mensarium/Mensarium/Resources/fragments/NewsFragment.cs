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

namespace Mensarium
{
    class NewsFragment : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.NewsFragment, container, false);

            List<FeedItem> lista = new List<FeedItem>();
            lista.Add(new FeedItem() { feedIme = "Nikola Savic", feedVreme = "18h", status = "Pomfrit sada. Brzo!"});
            lista.Add(new FeedItem() { feedIme = "Petar Peric", feedVreme = "14h", status = "Pasulj njah!"});

            var listView = view.FindViewById<ListView>(Resource.Id.FeedListView);
            listView.Adapter = new FeedListAdapter(this, lista);

            return view;
        }
    }
}