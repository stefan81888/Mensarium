﻿using System;
using System.Collections.Generic;
using System.Linq;



namespace MensariumDesktop.Model.Components.DTOs
{
    public class PozivanjaFullDto
    {
        public int IdPoziva { get; set; }
        public DateTime DatumPoziva { get; set; }
        public DateTime VaziDo { get; set; }

        //Pozivanja -> Korisnici
        public int IdPozivaoca { get; set; }

        public List<int> Pozvani { get; set; }

        public PozivanjaFullDto()
        {
            Pozvani = new List<int>();
        }

    }
}