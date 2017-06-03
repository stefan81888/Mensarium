using System;
using System.Collections.Generic;
using System.Linq;


namespace MensariumDesktop.Model.Components.DTOs
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