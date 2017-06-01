using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mensarium.Comp;

namespace Mensarium
{

    [Activity(Theme = "@android:style/Theme.DeviceDefault", Label = "Lista svih menzi")]
    public class SveMenzeActivity : Activity
    {
        private ListaMenzi listaMenzi = ListaMenzi.InstancaListaMenzi;
        private ListView listaView;

        private int pos = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SveMenze);

            ActionBar.SetDisplayHomeAsUpEnabled(true);

            listaView = FindViewById<ListView>(Resource.Id.SveMenzeListView);
            //listaView.SetScrollContainer(false);

            listaView.Adapter = new MenzeListAdapter(this, listaMenzi.Lista);

            //event long click
            listaView.ItemLongClick += ListaViewOnItemLongClick;

            //refresh
            //listaView.i
        }

        private void ListaViewOnItemLongClick(object sender, AdapterView.ItemLongClickEventArgs itemLongClickEventArgs)
        {
            /*
            PopupMenu popup = new PopupMenu(this, listaView, GravityFlags.Center);

            popup.MenuInflater.Inflate(Resource.Menu.popup_menu, popup.Menu);

            popup.MenuItemClick += PopupOnMenuItemClick;

            popup.Show();
            */

            this.pos = itemLongClickEventArgs.Position;

            var alert = new AlertDialog.Builder(this);
            //alert.SetTitle("Odaberi akciju");

            var items = new string[]
            {
                "Postavi kao moju menzu",
                "Prikazi menzu na mapi"
            };

            alert.SetItems(items, Handler);

            alert.Show();
        }

        private void Handler(object sender, DialogClickEventArgs dialogClickEventArgs)
        {
            if (dialogClickEventArgs.Which == 0)
            {
                var prefs = Application.Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
                var prefEditor = prefs.Edit();

                prefEditor.PutInt("OmiljenaMezna", this.pos);
                prefEditor.Commit();

                Toast.MakeText(this, "Omiljena menza postavljena!", ToastLength.Short).Show();
            };
        }

        //private void PopupOnMenuItemClick(object sender, PopupMenu.MenuItemClickEventArgs menuItemClickEventArgs)

        public override bool OnNavigateUp()
        {
            SetResult(0);
            Finish();
            return true;
        }
    }
}