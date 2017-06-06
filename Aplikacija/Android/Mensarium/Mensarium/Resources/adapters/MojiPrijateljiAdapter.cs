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
using Mensarium.Comp;
using MensariumDesktop.Model.Components.DTOs;
using System.Threading;
using DE.Hdodenhof.Circleimageview;

namespace Mensarium.Resources.adapters
{
    public class MojiPrijateljiAdapter : BaseAdapter<KorisnikFollowDto>, IFilterable
    {
        private Activity Context;
        public List<KorisnikFollowDto> listaPrijatelja;
        public List<KorisnikFollowDto> orgPodaci;
        private KorisnikFollowDto korisnik;

        public MojiPrijateljiAdapter(Activity con, List<KorisnikFollowDto> lista)
        {
            this.Context = con;
            this.listaPrijatelja = lista;

            Filter = new PronadjiPrijatelja(this);
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

            var holder = (ViewHolderMojiPrijatelji) view.Tag;

            korisnik = this[position];

            holder.PrijateljIme.Text = korisnik.Ime + " " + korisnik.Prezime;
            holder.PrijateljUsername.Text = "@" + korisnik.KorisnickoIme;
            holder.PrijateljFax.Text = korisnik.Fakultet;

            var slika = holder.PrijateljSlika;
            slika.SetImageBitmap(ImageManager.Get(this.Context, korisnik.IdKorisnika));

            Button dugmePozovi = holder.Dugme;
            dugmePozovi.Text = "Otprati";
            dugmePozovi.Tag = korisnik.IdKorisnika + " " + korisnik.Ime + " " + korisnik.Prezime;
            dugmePozovi.SetOnClickListener(new ButtonOtpratiClickListener(this.Context));

            return view;

        }

        public Filter Filter { get; private set; }

        public override void NotifyDataSetChanged()
        {
            base.NotifyDataSetChanged();
        }
    }

    public class ButtonOtpratiClickListener : Java.Lang.Object, View.IOnClickListener
    {
        private Activity activity;
        private AlertDialog alertObrada;
        private AlertDialog alertUspesno;

        public ButtonOtpratiClickListener(Activity activity)
        {
            this.activity = activity;
        }

        public void OnClick(View v)
        {
            string tag = (string)v.Tag;
            string[] split = tag.Split(null);

            alertUspesno = new AlertDialog.Builder(this.activity).Create();
            alertUspesno.SetTitle("Obavestenje!");
            alertUspesno.SetMessage("Uspesno ste otpratili korisnika: " + split[1] + " " + split[2]);

            alertUspesno.SetButton("U redu",
                delegate (object sender, DialogClickEventArgs args) { alertUspesno.Dispose(); });

            alertObrada = new AlertDialog.Builder(this.activity).Create();
            alertObrada.SetTitle("Obrada!");
            alertObrada.SetMessage("Molimo sacekajte!");
            alertObrada.Show();

            Thread novaNit = new Thread(() => FuncijaNoveNiti(split[0]));
            novaNit.Start();
        }

        private void FuncijaNoveNiti(string s)
        {
            try
            {
                Api.Api.Unfolow(Int32.Parse(s));

                this.activity.RunOnUiThread(() => alertObrada.Dismiss());
                this.activity.RunOnUiThread(() => alertUspesno.Show());
            }
            catch (Exception ex)
            {
                this.activity.RunOnUiThread(() => alertObrada.Dismiss());
                this.activity.RunOnUiThread(() => Toast.MakeText(this.activity, ex.Message, ToastLength.Short).Show());
            }
        }
    }
}