using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using Mensarium.Comp;
using Mensarium.Resources.activities;

namespace Mensarium
{

    [Activity(Theme = "@android:style/Theme.DeviceDefault", Label = "Lista svih menzi")]
    public class SveMenzeActivity : Activity
    {
        private ListaMenzi listaMenzi = ListaMenzi.InstancaListaMenzi;
        private ListView listaView;

        private SwipeRefreshLayout swipe;

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

            //event short click
            listaView.ItemClick += ListaViewOnItemClick;

            swipe = FindViewById<SwipeRefreshLayout>(Resource.Id.swipeSveMenze);
            swipe.Refresh += SwipeMenze;
        }

        private void SwipeMenze(object sender, EventArgs eventArgs)
        {
            listaMenzi.RefreshLista();
            listaMenzi = ListaMenzi.InstancaListaMenzi;
            swipe.Refreshing = false;
        }

        private void ListaViewOnItemClick(object sender, AdapterView.ItemClickEventArgs itemClickEventArgs)
        {
            MenzaItem menza = listaMenzi.Lista[itemClickEventArgs.Position];

            var alert = new AlertDialog.Builder(this);
            alert.SetTitle("Informacije o menzi");
            alert.SetPositiveButton("U redu", (o, args) => { alert.Dispose(); });

            string poruka = "Ime menze: " + menza.MenzaFull.Naziv +
                            "\nLokacija menze: " + menza.MenzaFull.Lokacija +
                            "\nRadno vreme menze: " + menza.MenzaFull.RadnoVreme;

            if (menza.MenzaFull.VanrednoNeRadi)
                poruka += "\nVanredno NE RADI!";

            alert.SetMessage(poruka);
            
            alert.Show();

        }

        private void ListaViewOnItemLongClick(object sender, AdapterView.ItemLongClickEventArgs itemLongClickEventArgs)
        {

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
            }
            else
            {
                var intent = new Intent(this, typeof(MapActivity));
                intent.PutExtra("MenzaZaPrikaz", this.pos);
                StartActivity(intent);
            }
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