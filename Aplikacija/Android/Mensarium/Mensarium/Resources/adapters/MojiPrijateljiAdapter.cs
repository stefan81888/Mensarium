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
using Mensarium.Components;

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
                var PUsername = view.FindViewById<TextView>(Resource.Id.profilPrijateljaItemUsername);
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

            Button dugmePosaljiObrok = view.FindViewById<Button>(Resource.Id.pozoviPrijateljaObrokDugme);
            dugmePosaljiObrok.Tag = dugmePozovi.Tag = korisnik.IdKorisnika + " " + korisnik.Ime + " " + korisnik.Prezime;
            dugmePosaljiObrok.SetOnClickListener(new ButtonPosaljiClickListener(this.Context));

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

    public class ButtonPosaljiClickListener : Java.Lang.Object, View.IOnClickListener
    {
        private Activity activity;
        private AlertDialog alertObrada;
        private AlertDialog alertUspesno;
        private AlertDialog obrociDialog;

        private Spinner spinerDorucak;
        private Spinner spinerRucak;
        private Spinner spinerVecera;

        private int brojDorucka = 0;
        private int brojRucka = 0;
        private int brojVecera = 0;

        private KorisnikStanjeDto posalji = new KorisnikStanjeDto();

        public ButtonPosaljiClickListener(Activity activity)
        {
            this.activity = activity;
        }

        public void OnClick(View v)
        {
            string tag = (string)v.Tag;
            string[] split = tag.Split(null);

            alertUspesno = new AlertDialog.Builder(this.activity).Create();
            alertUspesno.SetTitle("Obavestenje!");
            alertUspesno.SetMessage("Uspesno ste poslali korisniku: " + split[1] + " " + split[2] + " obrok(e).");

            alertUspesno.SetButton("U redu",
                delegate (object sender, DialogClickEventArgs args) { alertUspesno.Dispose(); });

            alertObrada = new AlertDialog.Builder(this.activity).Create();
            alertObrada.SetTitle("Obrada!");
            alertObrada.SetMessage("Molimo sacekajte!");
            //alertObrada.Show();

            var brojeviObroka = Api.Api.KorisnikovoStanjeObroka(MSettings.CurrentSession.LoggedUser.UserID);

            var inflater = LayoutInflater.From(this.activity);
            var view = inflater.Inflate(Resource.Layout.posaljiObrokDialog, null);
            obrociDialog = new AlertDialog.Builder(this.activity).Create();
            obrociDialog.SetView(view);

            spinerDorucak = view.FindViewById<Spinner>(Resource.Id.spinerPosaljiDorucak);
            spinerRucak = view.FindViewById<Spinner>(Resource.Id.spinerPosaljiRucak);
            spinerVecera = view.FindViewById<Spinner>(Resource.Id.spinerPosaljiVeceru);

            List<string> nizDorucka = new List<string>();
            for(int i = 0; i <= brojeviObroka.BrojDorucka; ++i)
                nizDorucka.Add(i.ToString());
            spinerDorucak.Adapter = new ArrayAdapter<string>(this.activity, Android.Resource.Layout.SimpleSpinnerItem, nizDorucka);

            List<string> nizRuckova = new List<string>();
            for (int i = 0; i <= brojeviObroka.BrojRuckova; ++i)
                nizRuckova.Add(i.ToString());
            spinerRucak.Adapter = new ArrayAdapter<string>(this.activity, Android.Resource.Layout.SimpleSpinnerItem, nizRuckova);

            List<string> nizVecera = new List<string>();
            for (int i = 0; i <= brojeviObroka.BrojVecera; ++i)
                nizVecera.Add(i.ToString());
            spinerVecera.Adapter = new ArrayAdapter<string>(this.activity, Android.Resource.Layout.SimpleSpinnerItem, nizVecera);

            spinerDorucak.ItemSelected += delegate(object sender, AdapterView.ItemSelectedEventArgs args) { this.brojDorucka = (int)spinerDorucak.GetItemIdAtPosition(args.Position); };
            spinerRucak.ItemSelected += delegate (object sender, AdapterView.ItemSelectedEventArgs args) { this.brojRucka = (int)spinerRucak.GetItemIdAtPosition(args.Position); };
            spinerVecera.ItemSelected += delegate (object sender, AdapterView.ItemSelectedEventArgs args) { this.brojVecera = (int)spinerVecera.GetItemIdAtPosition(args.Position); };

            obrociDialog.SetButton("Posalji", delegate(object sender, DialogClickEventArgs args)
            {
                obrociDialog.Dispose();

                posalji.BrojDorucka = this.brojDorucka;
                posalji.BrojRuckova = this.brojRucka;
                posalji.BrojVecera = this.brojVecera;
                
                alertObrada.Show();

                Thread novaNit = new Thread(() => FuncijaNoveNiti(split[0]));
                novaNit.Start();
            });

            obrociDialog.SetButton2("Odustani", delegate(object sender, DialogClickEventArgs args) { obrociDialog.Dispose(); });

            obrociDialog.Show();

            //Thread novaNit = new Thread(() => FuncijaNoveNiti(split[0]));
            //novaNit.Start();
        }

        private void FuncijaNoveNiti(string s)
        {
            try
            {
                Api.Api.PosaljiObrok(Int32.Parse(s), posalji);

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