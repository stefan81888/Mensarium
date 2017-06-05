using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{
    
    public class MealTodayAdded
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public MealType Type { get; set; }
        public Mensa MensaAdded { get; set; }

        public string MensaName { get { return MensaAdded.Name; } }
    }

    public enum MealType
    {
        Dorucak = 1,
        Rucak,
        Vecera
    }
}
