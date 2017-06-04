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
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium.Resources.adapters
{
    class ProfilItemAdapter : BaseAdapter<KorisnikFullDto>
    {
        private List<KorisnikFullDto> listaKorisnika;
        private MainActivity Context;
        private KorisnikFullDto korisnik;
        private View view;
        private Button dugme;

        public ProfilItemAdapter(MainActivity con, List<KorisnikFullDto> lista)
        {
            this.Context = con;
            this.listaKorisnika = lista;
        }

        public override int Count { get { return listaKorisnika.Count; }}

        public override KorisnikFullDto this[int positon] { get { return this.listaKorisnika[positon]; }}

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            view = convertView;

            if (view == null)
                view = Context.LayoutInflater.Inflate(Resource.Layout.profilItem, parent, false);

            korisnik = this[position];
            view.FindViewById<TextView>(Resource.Id.profilItemIme).Text = korisnik.Ime + " " + korisnik.Prezime;
            view.FindViewById<TextView>(Resource.Id.profilItemUsername).Text = "@" + korisnik.KorisnickoIme;

            dugme = view.FindViewById<Button>(Resource.Id.zapratiDugme);
            if (dugme.Text.Equals("Zaprati"))
                dugme.Click += ZapratiClick;
            else
                dugme.Click += OtpratiClick;

            try
            {
                FakultetFullDto fax = Api.Api.GetFacultyInfo(korisnik.IdFakulteta.Value);
                view.FindViewById<TextView>(Resource.Id.profilItemFax).Text = fax.Naziv;

                return view;
            }
            catch (Exception ex)
            {
                view.FindViewById<TextView>(Resource.Id.profilItemFax).Text = "Fakultet nije pronadjen";

                return view;
            }
        }

        private void ZapratiClick(object sender, EventArgs eventArgs)
        {
            try
            {
                Api.Api.FollowUser(korisnik.IdKorisnika);
                dugme.Text = "Otprati";
            }
            catch (Exception ex)
            {
                Toast.MakeText(Context, ex.Message, ToastLength.Short).Show();
            }
        }

        private void OtpratiClick(object sender, EventArgs eventArgs)
        {
            try
            {
                Api.Api.Unfolow(korisnik.IdKorisnika);
                dugme.Text = "Zaprati";
            }
            catch (Exception ex)
            {
                Toast.MakeText(Context, ex.Message, ToastLength.Short).Show();
            }
        }
    }
}