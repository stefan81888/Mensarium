using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.App_Start
{
    public class MapiranjeDto : Profile
    {
        public MapiranjeDto()
        {
            Mapper.CreateMap<Fakultet, FakultetDto>();
            Mapper.CreateMap<FakultetDto, Fakultet>();

            Mapper.CreateMap<Korisnik, KorisnikDto>();
            Mapper.CreateMap<KorisnikDto, Korisnik>();

            Mapper.CreateMap<LoginSesije, LoginSesijeDto>();
            Mapper.CreateMap<LoginSesijeDto, LoginSesije>();

            Mapper.CreateMap<Menza, MenzaDto>();
            Mapper.CreateMap<MenzaDto, Menza>();

            Mapper.CreateMap<Objave, ObjaveDto>();
            Mapper.CreateMap<ObjaveDto, Objave>();

            Mapper.CreateMap<Obrok, ObrokDto>();
            Mapper.CreateMap<ObrokDto, Obrok>();

            Mapper.CreateMap<Pozivanja, PozivanjaDto>();
            Mapper.CreateMap<PozivanjaDto, Pozivanja>();

            Mapper.CreateMap<PozivanjaPozvani, PozivanjaPozvaniDto>();
            Mapper.CreateMap<PozivanjaPozvaniDto, PozivanjaPozvani>();

            Mapper.CreateMap<Pracenja, PracenjaDto>();
            Mapper.CreateMap<PracenjaDto, Pracenja>();

            Mapper.CreateMap<Privilegija, PrivilegijaDto>();
            Mapper.CreateMap<PrivilegijaDto, Privilegija>();

            Mapper.CreateMap<TipNaloga, TipNalogaDto>();
            Mapper.CreateMap<TipNalogaDto, TipNaloga>();

            Mapper.CreateMap<TipObroka, TipObrokaDto>();
            Mapper.CreateMap<TipObrokaDto, TipObroka>();
        }
    }
}