﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class ClientLoginDto //ceo email i pass
    {
        public string KIme_Mail { get; set; }
        public string Sifra { get; set; }
    }
}