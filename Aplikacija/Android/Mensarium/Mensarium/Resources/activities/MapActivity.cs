using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mensarium.Comp;
using Xamarin.Forms;

namespace Mensarium.Resources.activities
{

    [Activity(Label = "Menza na mapi")]
    public class MapActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap mapa;
        //private int indexMenzeZaPrikaz;
        private MenzaItem menzaZaPrikaz;
        private ListaMenzi listaMenzi = ListaMenzi.InstancaListaMenzi;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MapActivity);

            //indexMenzeZaPrikaz = Intent.GetIntExtra("MenzaZaPrikaz", 0);
            menzaZaPrikaz = listaMenzi.Lista[Intent.GetIntExtra("MenzaZaPrikaz", 0)];

            SetujMapu();
        }

        private void SetujMapu()
        {
            if (mapa == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.mapID).GetMapAsync(this);
            }
        }

        //getmapasync zove ovu
        public void OnMapReady(GoogleMap googleMap)
        {
            mapa = googleMap;
            mapa.MapType = GoogleMap.MapTypeNormal;

            LatLng latlng = new LatLng(menzaZaPrikaz.latiCoo, menzaZaPrikaz.longCoo);

            mapa.MoveCamera(CameraUpdateFactory.NewLatLngZoom(latlng, 13));

            MarkerOptions marker = new MarkerOptions()
                .SetPosition(latlng)
                .SetTitle(menzaZaPrikaz.Ime);

            mapa.AddMarker(marker);
        }
    }
}