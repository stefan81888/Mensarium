using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{

    
    public class User
    {
        //TO-DO Dinamicki preuzmi iz baze podataka
        public enum UserAccountType
        {
            Administrator = 1,
            Menadzer,
            Uplata,
            Naplata,
            Korisnik
        }
        //TO-DO Dinamicki preuzmi iz baze
        public enum UserPrivileges
        {
            DodavanjeAdmina = 1,
            DodavanjeMenadzer,
            DodavanjeUplata,
            DodavanjeNaplata,
            DodavanjeKorisnik,

            BrisanjeAdmin,
            BrisanjeMenadzer,
            BrisanjeUplata,
            BrisanjeNaplata,
            BrisanjeKorisnik,

            ModifikacijaAdmin,
            ModifikacijaMenadzer,
            ModifikacijaUplata,
            ModifikacijaNaplata,
            ModifikacijaKorisnik,

            CitanjeAdmin,
            CitanjeMenadzer,
            CitanjeUplata,
            CitanjeNaplata,
            CitanjeKorisnik,

            DodavanjeObrok,
            BrisanjeObrok,
            ModifikacijaObrok,
            CitanjeObrok
        }

        public int UserID { get; set; }
        public String Username { get; set; }
        public String Email { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public String PhoneNumber { get; set; }
        public UserAccountType AccountType { get; set; }
        public List<UserPrivileges> UserPrivilegeses { get; set; }


    }
}
