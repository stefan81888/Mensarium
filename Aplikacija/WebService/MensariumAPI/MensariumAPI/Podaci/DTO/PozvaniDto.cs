using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class PozvaniDto // // ne koristi se
    {
        public List<int> Pozvani { get; set; }

        public PozvaniDto()
        {
            Pozvani = new List<int>();
        }
    }
}