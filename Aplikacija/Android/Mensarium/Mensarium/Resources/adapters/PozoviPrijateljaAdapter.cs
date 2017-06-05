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

            Button dugmePozovi = view.FindViewById<Button>(Resource.Id.pozoviPrijateljaItemDugme);
            dugmePozovi.Tag = korisnik.IdKorisnika;
            dugmePozovi.SetOnClickListener(new ButtonClickListener(this.Context));

            return view;
  
        }

        public Filter Filter { get; private set; }

        public override void NotifyDataSetChanged()
        {
            base.NotifyDataSetChanged();
        }
    }

    public class ButtonClickListener : Java.Lang.Object, View.IOnClickListener
    {
        private Activity activity;

        public ButtonClickListener(Activity activity)
        {
            this.activity = activity;
        }

        public void OnClick(View v)
        {
            string name = (string)v.Tag;
            string text = string.Format("{0} Button Click.", name);
            Toast.MakeText(this.activity, text, ToastLength.Short).Show();
        }
    }
}