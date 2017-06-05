using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{
    
    public class MealReclamation
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public MealType Type { get; set; }
        public Mensa Mensa { get; set; }

        public string MensaName { get { return Mensa.Name; } }
    }

    public enum MealType
    {
        Dorucak = 1,
        Rucak,
        Vecera
    }
}
