using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensariumDesktop.Model.Controllers;

namespace MensariumDesktop.Model.Components
{
    public class Mensa
    {
        public static List<Mensa> Mensas { get; protected set; }

        public static void UpdateMensaList()
        {
            Mensas = MUtility.MensaList_FromMensaFullDto(Api.GetAllMensas());
        }
        public int MensaID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string WorkTime { get; set; }
        public bool CurrentlyClosed { get; set; }
    }
}
