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
using DE.Hdodenhof.Circleimageview;
using Java.Lang;
using Mensarium.Comp;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium.Resources.adapters
{
    public class PozoviPrijateljaAdapter : BaseAdapter<KorisnikFollowDto>, IFilterable
    {
        private Activity Context;
        public List<KorisnikFollowDto> listaPrijatelja;
        public List<KorisnikFollowDto> orgPodaci;
        private KorisnikFollowDto korisnik;

        public PozoviPrijateljaAdapter(Activity con, List<KorisnikFollowDto> lista)
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

            if (view == null)
            {
                view = Context.LayoutInflater.Inflate(Resource.Layout.pozoviItem, parent, false);

                var PIme = view.FindViewById<TextView>(Resource.Id.profilPrijateljaItemIme);
                var PUsername = view.FindViewById<TextView>(Resource.Id.profilPrijateljaItemFax);
                var PFax = view.FindViewById<TextView>(Resource.Id.profilPrijateljaItemFax);
                var PButton = view.FindViewById<Button>(Resource.Id.pozoviPrijateljaItemDugme);
                var PSlika = view.FindViewById<CircleImageView>(Resource.Id.profilPrijateljaItemSlika);

                var vh = new ViewHolderMojiPrijatelji()
                {
                    Dugme = PButton,
                    PrijateljUsername = PUsername,
                    PrijateljIme = PIme,
                    PrijateljFax = PFax,
                    PrijateljSlika = PSlika
                };

                view.Tag = vh;
            }

            var holder = (ViewHolderMojiPrijatelji)view.Tag;

            korisnik = this[position];

            holder.PrijateljIme.Text = korisnik.Ime + " " + korisnik.Prezime;
            holder.PrijateljUsername.Text = "@" + korisnik.KorisnickoIme;
            holder.PrijateljFax.Text = korisnik.Fakultet;

            var slika = holder.PrijateljSlika;
            slika.SetImageBitmap(ImageManager.Get(this.Context, korisnik.IdKorisnika));

            Button dugmePozovi = holder.Dugme;
            dugmePozovi.Tag = korisnik.IdKorisnika;
            dugmePozovi.SetOnClickListener(new ButtonPozoviClickListener(this.Context));

            return view;
  
        }

        public Filter Filter { get; private set; }

        public override void NotifyDataSetChanged()
        {
            base.NotifyDataSetChanged();
        }
    }

    public class ButtonPozoviClickListener : Java.Lang.Object, View.IOnClickListener
    {
        private Activity activity;

        public ButtonPozoviClickListener(Activity activity)
        {
            this.activity = activity;
        }

        public void OnClick(View v)
        {
            string id = (string)v.Tag;

            try
            {
                Api.Api.InviteUser(activity.Intent.GetIntExtra("IdPoziva", 0), Int32.Parse(id));
            }
            catch (System.Exception ex)
            {
                Toast.MakeText(activity, ex.Message, ToastLength.Long).Show();
            }
        }
    }
}