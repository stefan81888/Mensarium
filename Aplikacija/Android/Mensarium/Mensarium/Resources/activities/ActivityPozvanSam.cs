using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using Mensarium.Resources.adapters;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium.Resources.activities
{
    [Activity(Label = "Odgovori na pozive")]
    public class ActivityPozvanSam : Activity
    {
        private ListView pozvanSam;
        private SwipeRefreshLayout swipe;
        private List<PozivanjaNewsFeedItemDto> lista;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.OdgovoriNaPozive);

            pozvanSam = FindViewById<ListView>(Resource.Id.pozvanSamListView);
            SetujPozanSamListu();

            swipe = FindViewById<SwipeRefreshLayout>(Resource.Id.swipeOgovori);
            swipe.Refresh += SwipeOnRefresh;
        }

        private void SwipeOnRefresh(object sender, EventArgs eventArgs)
        {
            SetujPozanSamListu();
            swipe.Refreshing = false;
        }

        private void SetujPozanSamListu()
        {
            try
            {
                lista = Api.Api.UserCalledBy();
                if (lista.Count != 0)
                    pozvanSam.Adapter = new PozvanSamAdapter(this, lista);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Niko Vas trenutno nije pozvao :(", ToastLength.Long).Show();
            }


            //List<PozivanjaNewsFeedItemDto> lista = Api.Api.UserCalledBy();
            //pozvanSam.Adapter = new PozvanSamAdapter(this, lista);

            //Thread novaNit = new Thread(ApiFjaZaNit);
            //novaNit.Start();
        }


        private void ApiFjaZaNit()
        {
            try
            {
                lista = Api.Api.UserCalledBy();
                if (lista.Count != 0)
                {
                    this.RunOnUiThread(() => pozvanSam.Adapter = new PozvanSamAdapter(this, lista));
                    this.RunOnUiThread(() => swipe.Refreshing = false);
                }
            }
            catch (Exception ex)
            {
                this.RunOnUiThread(() => Toast.MakeText(this, "Niko Vas trenutno nije pozvao :(", ToastLength.Long).Show());
                this.RunOnUiThread(() => swipe.Refreshing = false);
            }
            finally
            {
                //this.RunOnUiThread(() => pozvanSam.Adapter = new PozvanSamAdapter(this, lista));
            }
        }
    }
}