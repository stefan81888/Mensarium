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
using MensariumAPI.Podaci.DTO;

namespace Mensarium.Resources.adapters
{
    class OdgovorListAdapter : BaseAdapter<OgovorNaPozivDto>
    {
        private List<OgovorNaPozivDto> lista;
        private Activity context;

        public OdgovorListAdapter(Activity c, List<OgovorNaPozivDto> l)
        {
            this.context = c;
            this.lista = l;
        }

        public override OgovorNaPozivDto this[int position] {get { return this.lista[position]; }}

        public override int Count { get { return this.lista.Count; }}

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.odgovorItem, parent, false);

                var Ime = view.FindViewById<TextView>(Resource.Id.prihvatioIme);
                var Username = view.FindViewById<TextView>(Resource.Id.prihvatioUsername);
                var Check = view.FindViewById<CheckBox>(Resource.Id.prihvatioCheck);

                var vh = new ViewHolderPrihvatio()
                {
                    PrihvatioIme = Ime,
                    PrihvatioUsername = Username,
                    PrihvatioSwitch = Check
                };

                view.Tag = vh;
            }

            var holder = (ViewHolderPrihvatio) view.Tag;

            OgovorNaPozivDto odgovor = this[position];

            holder.PrihvatioIme.Text = odgovor.Ime + " " + odgovor.Prezime;
            holder.PrihvatioUsername.Text = "@" + odgovor.KorisnickoIme;
            holder.PrihvatioSwitch.Checked = odgovor.OdgovorPozvanog;

            holder.PrihvatioSwitch.Clickable = false;

            return view;
        }
    }
}