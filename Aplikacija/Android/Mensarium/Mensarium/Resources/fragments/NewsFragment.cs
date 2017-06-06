using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using Mensarium.Components;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium
{
    class NewsFragment : Android.Support.V4.App.Fragment
    {
        private SwipeRefreshLayout swipe;
        private List<ObjavaReadDto> lista;
        private ListView listView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.NewsFragment, container, false);

            lista = new List<ObjavaReadDto>();
            //lista.Add(new FeedItem() { feedIme = "Nikola Savic", feedVreme = "18h", status = "Pomfrit sada. Brzo!"});
            //lista.Add(new FeedItem() { feedIme = "Petar Peric", feedVreme = "14h", status = "Pasulj njah!"});

            try
            {
                lista = Api.Api.GetFollowedUsersPosts(MSettings.CurrentSession.LoggedUser.UserID);

                listView = view.FindViewById<ListView>(Resource.Id.FeedListView);
                listView.Adapter = new FeedListAdapter(this, lista);

                swipe = view.FindViewById<SwipeRefreshLayout>(Resource.Id.swipeContainer);
                swipe.Refresh += Swipe_Refresh;
                return view;
            }
            catch (Exception ex)
            {
                Toast.MakeText(this.Context, ex.Message, ToastLength.Long).Show();
                return view;
            }
        }

        private void Swipe_Refresh(object sender, EventArgs e)
        {
            try
            {
                lista = Api.Api.GetFollowedUsersPosts(MSettings.CurrentSession.LoggedUser.UserID);

                listView.Adapter = new FeedListAdapter(this, lista);

                swipe.Refreshing = false;
            }
            catch (Exception ex)
            {
                swipe.Refreshing = false;

                Toast.MakeText(this.Context, ex.Message, ToastLength.Long).Show();
            }
        }
    }
}