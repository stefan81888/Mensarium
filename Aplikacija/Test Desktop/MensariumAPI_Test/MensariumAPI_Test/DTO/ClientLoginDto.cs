﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MensariumAPI.Podaci.DTO
{
    public class ClientLoginDto //ceo email i pass
    {
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
    }
}