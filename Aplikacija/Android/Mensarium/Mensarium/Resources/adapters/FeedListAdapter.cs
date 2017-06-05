using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DE.Hdodenhof.Circleimageview;
using MensariumDesktop.Model.Components.DTOs;
using Object = Java.Lang.Object;

namespace Mensarium
{
    class FeedListAdapter : BaseAdapter<ObjavaReadDto>
    {
        //private Activity context;
        private List<ObjavaReadDto> list;

        private NewsFragment context;


        public FeedListAdapter(NewsFragment _context, List<ObjavaReadDto> _list) : base()
        {
            this.context = _context;
            this.list = _list;
        }

        public override ObjavaReadDto this[int position] { get { return list[position]; }}

        public override int Count { get { return list.Count; } }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            //if (view == null) view = context.LayoutInflater.Inflate(Resource.Layout.ListItemRow, parent, false);
            if (view == null) view = context.Activity.LayoutInflater.Inflate(Resource.Layout.ListItemRow, parent, false);

            ObjavaReadDto item = this[position];
            view.FindViewById<TextView>(Resource.Id.FeedIme).Text = item.ImeKorisnika + " " + item.PrezimeKorisnika;
            view.FindViewById<TextView>(Resource.Id.FeedVreme).Text = item.DatumObjave.ToLongTimeString() + " " + item.DatumObjave.ToShortDateString();
            view.FindViewById<TextView>(Resource.Id.FeedStatus).Text = item.TekstObjave;

            return view;
        }
    }
}