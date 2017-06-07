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
using Mensarium.Components;
using Mensarium.Resources.activities;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium.Resources.adapters
{
    class PozvanSamAdapter : BaseAdapter<PozivanjaNewsFeedItemDto>
    {
        private List<PozivanjaNewsFeedItemDto> lista;
        private ActivityPozvanSam context;

        public PozvanSamAdapter(ActivityPozvanSam c, List<PozivanjaNewsFeedItemDto> l)
        {
            this.context = c;
            this.lista = l;
        }

        public override PozivanjaNewsFeedItemDto this[int position] { get { return this.lista[position]; }}

        public override int Count { get { return this.lista.Count; }}

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.pozvanSamItem, parent, false);

            PozivanjaNewsFeedItemDto p = this[position];

            view.FindViewById<TextView>(Resource.Id.pozvanSamIme).Text = p.ImePozivaoca + " " + p.PrezimePozivaoca;
            view.FindViewById<TextView>(Resource.Id.pozvanSamUsername).Text = "@" + p.KorisnickoImePozivaoca;

            view.FindViewById<TextView>(Resource.Id.pozvanSamVaziOd).Text = p.DatumPoziva.ToShortTimeString() + p.DatumPoziva.ToShortDateString();
            view.FindViewById<TextView>(Resource.Id.pozvanSamVaziDo).Text = p.VaziDo.ToShortTimeString() + p.VaziDo.ToShortDateString();

            Button dugme = view.FindViewById<Button>(Resource.Id.odgovoriItemDugme);
            dugme.Tag = p.IdPoziva;
            dugme.SetOnClickListener(new ButtonOdgovoriClickListener(this.context));

            return view;
        }

        public class ButtonOdgovoriClickListener : Java.Lang.Object, View.IOnClickListener
        {
            private Activity activity;

            public ButtonOdgovoriClickListener(Activity activity)
            {
                this.activity = activity;
            }

            public void OnClick(View v)
            {
                string id = (string)v.Tag;
                PozivanjaPozvaniDto odg = new PozivanjaPozvaniDto();
                odg.IdPoziva = Int32.Parse(id);
                odg.IdPozvanog = MSettings.CurrentSession.LoggedUser.UserID;

                try
                {
                    AlertDialog alert = new AlertDialog.Builder(activity).Create();
                    alert.SetTitle("Odgovor na poziv");
                    alert.SetMessage("Da li dolazim?");

                    alert.SetButton("Da", delegate(object sender, DialogClickEventArgs args)
                    {
                        odg.OdgovorPozvanog = true;
                        try
                        {
                            Api.Api.Respond2Invite(odg);
                        }
                        catch (Exception ex)
                        {
                            Toast.MakeText(activity, ex.Message, ToastLength.Long).Show();
                        }
                    });

                    alert.SetButton2("Ne", delegate(object sender, DialogClickEventArgs args)
                    {
                        odg.OdgovorPozvanog = false;
                        try
                        {
                            Api.Api.Respond2Invite(odg);
                        }
                        catch (Exception ex)
                        {
                            Toast.MakeText(activity, ex.Message, ToastLength.Long).Show();
                        }
                    });

                    alert.Show();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(activity, ex.Message, ToastLength.Long).Show();
                }
            }
        }
    }
}