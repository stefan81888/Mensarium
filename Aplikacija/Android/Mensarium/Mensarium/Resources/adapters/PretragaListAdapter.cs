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
    class PretragaListAdapter : BaseAdapter<KorisnikFollowDto>
    {
        private List<KorisnikFollowDto> lista;
        private MainSwipePage context;


        public PretragaListAdapter(MainSwipePage c, List<KorisnikFollowDto> l)
        {
            context = c;
            lista = l;
        }

        public override KorisnikFollowDto this[int position] { get { return this.lista[position]; }}

        public override int Count { get { return this.lista.Count; }}

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if(view == null) view = context.LayoutInflater.Inflate(Resource.Layout.PretragaItem, parent, false);

            KorisnikFollowDto korisnik = this[position];

            view.FindViewById<TextView>(Resource.Id.pretragaItemIme).Text = korisnik.Ime + " " + korisnik.Prezime;
            view.FindViewById<TextView>(Resource.Id.pretragaItemUsername).Text = "@" + korisnik.KorisnickoIme;
            view.FindViewById<TextView>(Resource.Id.pretragaItemFakultet).Text = korisnik.Fakultet;

            Button dugmeZaprati = view.FindViewById<Button>(Resource.Id.pretragaZapratiDugme);
            dugmeZaprati.Tag = korisnik.IdKorisnika + " " + korisnik.Ime + " " + korisnik.Prezime;
            dugmeZaprati.SetOnClickListener(new DugmeZapratiClickListener(this.context));

            return view;
        }

    }


    public class DugmeZapratiClickListener : Java.Lang.Object, View.IOnClickListener
    {
        private Activity activity;

        public DugmeZapratiClickListener(Activity activity)
        {
            this.activity = activity;
        }

        public void OnClick(View v)
        {
            string tag = (string)v.Tag;
            string[] split = tag.Split(null);

            try
            {
                Api.Api.FollowUser(Int32.Parse(split[0]));

                var alert = new AlertDialog.Builder(this.activity);
                alert.SetTitle("Obavestenje!");
                alert.SetMessage("Uspesno ste zapratili korisnika: " + split[1] + " " + split[2]);

                alert.SetPositiveButton("U redu",
                    delegate(object sender, DialogClickEventArgs args) { alert.Dispose(); });

                alert.Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this.activity, ex.Message, ToastLength.Short).Show();
            }
        }
    }
}