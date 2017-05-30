using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumDesktop.Model.Components.DTOs
{
    public class PozivanjaNewsFeedItemDto
    {
        public int IdPoziva { get; set; }
        public DateTime DatumPoziva { get; set; }
        public DateTime VaziDo { get; set; }
        public int IdPozivaoca { get; set; }
        public string ImePozivaoca { get; set; }
        public string PrezimePozivaoca { get; set; }
        public string KorisnickoImePozivaoca { get; set; }
    }
}