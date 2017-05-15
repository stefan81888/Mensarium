﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class PozivanjeDto
    {
        public int IdPoziva { get; protected set; }
        public DateTime DatumPoziva { get; set; }
        public DateTime VaziDo { get; set; }

        //Pozivanja -> Korisnici
        public KorisnikDto Pozivalac { get; set; }
        
    }
}