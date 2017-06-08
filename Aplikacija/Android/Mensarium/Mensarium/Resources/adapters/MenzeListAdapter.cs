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

namespace Mensarium
{
    class MenzeListAdapter : BaseAdapter<MenzaItem>
    {

        private List<MenzaItem> listaMenzi;
        private SveMenzeActivity context;
        private ProgressBar bar;
        private ProgressBar salterBar;

        public MenzeListAdapter(SveMenzeActivity con, List<MenzaItem> list)
        {
            this.context = con;
            this.listaMenzi = list;
        }

        public override MenzaItem this[int position] { get { return this.listaMenzi[position]; }}

        public override int Count { get { return this.listaMenzi.Count; }}

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.MojaMenzaRow, parent, false);

            MenzaItem item = this[position];
            view.FindViewById<TextView>(Resource.Id.ImeMenze).Text = item.MenzaFull.Naziv;
            view.FindViewById<TextView>(Resource.Id.LokacijaMenze).Text = item.MenzaFull.Lokacija;

            var radili = view.FindViewById<TextView>(Resource.Id.DaLiRadiMenza);
            if (item.MenzaFull.VanrednoNeRadi)
            {
                radili.Text = "Vanredno NE RADI!";
                radili.SetTextColor(Android.Graphics.Color.ParseColor("#ba1d1d"));
            }
            else
                view.FindViewById<TextView>(Resource.Id.DaLiRadiMenza).Text = "Radno vreme: " +
                                                                              item.MenzaFull.RadnoVreme;

            view.FindViewById<TextView>(Resource.Id.GuzvaText).Text = "Guzva u menzi: " + item.GuzvaFull.TrenutnaGuzvaZaJelo.ToString() + "%";
            view.FindViewById<TextView>(Resource.Id.GuzvaNaSalteruText).Text = "Guzvna na salteru: " +
                                                                               item.GuzvaFull.TrenutnaGuzvaZaUplatu.ToString() + "%";

            bar = view.FindViewById<ProgressBar>(Resource.Id.ProfilMenzaBar);
            bar.Max = 100;
            bar.Progress = item.GuzvaFull.TrenutnaGuzvaZaJelo;

            salterBar = view.FindViewById<ProgressBar>(Resource.Id.GuzvaNaSalteruBar);
            salterBar.Max = 100;
            salterBar.Progress = item.GuzvaFull.TrenutnaGuzvaZaUplatu;

            return view;
        }
    }
}