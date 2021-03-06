﻿using System;
using System.Collections.Generic;
using System.Linq;




namespace MensariumDesktop.Model.Components.DTOs
{
    public class ObrokFullDto
    {
        public int IdObroka { get; set; }
        public bool Iskoriscen { get; set; }
        public DateTime DatumUplacivanja { get; set; }
        public DateTime? DatumIskoriscenja { get; set; }
        public int IdUplatioca { get; set; }
        public int IdTipaObroka { get; set; }
        public int IdLokacijeUplate { get; set; }
        public int IdLokacijeIskoriscenja { get; set; }
    }
}