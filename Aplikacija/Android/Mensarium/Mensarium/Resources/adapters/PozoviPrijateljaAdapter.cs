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
using Java.Lang;
using Mensarium.Comp;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium.Resources.adapters
{
    public class PozoviPrijateljaAdapter : BaseAdapter<KorisnikFollowDto>, IFilterable
    {
        private PozoviPrijateljaActivity Context;
        public List<KorisnikFollowDto> listaPrijatelja;
        public List<KorisnikFollowDto> orgPodaci;
        private KorisnikFollowDto korisnik;

        public PozoviPrijateljaAdapter(PozoviPrijateljaActivity con, List<KorisnikFollowDto> lista)
        {
            this.Context = con;
            this.listaPrijatelja = lista;

            Filter = new PronadjiFilter(this);
        }

        public override KorisnikFollowDto this[int positon] { get { return this.listaPrijatelja[positon]; } }

        public override int Count { get { return listaPrijatelja.Count; } }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if(view == null)
                view = Context.LayoutInflater.Inflate(Resource.Layout.pozoviItem, parent, false);

            korisnik = this[position];

            view.FindViewById<TextView>(Resource.Id.profilPrijateljaItemIme).Text = korisnik.Ime + " " +
                                                                                    korisnik.Prezime;

            view.FindViewById<TextView>(Resource.Id.profilPrijateljaItemUsername).Text = "@" + korisnik.KorisnickoIme;
            view.FindViewById<TextView>(Resource.Id.profilPrijateljaItemFax).Text = korisnik.Fakultet;

            view.FindViewById<Button>(Resource.Id.pozoviPrijateljaItemDugme).Click += PozoviPrijatelja;

            return view;
  
        }

        private void PozoviPrijatelja(object sender, EventArgs eventArgs)
        {
            try
            {
                //Api.Api.
            }
            catch (System.Exception ex)
            {
                Toast.MakeText(Context, ex.Message, ToastLength.Short).Show();
            }
        }

        public Filter Filter { get; private set; }

        public override void NotifyDataSetChanged()
        {
            base.NotifyDataSetChanged();
        }
    }
}