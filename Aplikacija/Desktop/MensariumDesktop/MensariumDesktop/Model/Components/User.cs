using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{

    
    public class User
    {
        public static List<User> AllUsers;
        //TO-DO Dinamicki preuzmi iz baze podataka
        public enum UserAccountType
        {
            Administrator = 1,
            Menadzer,
            Uplata,
            Naplata,
            Student
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
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string PhoneNumber { get; set; }
        public UserAccountType AccountType { get; set; }
        public List<UserPrivileges> UserPrivilegeses { get; set; }
        public Image ProfilePicture { get; set; }
        public bool ActiveAccount { get; set; }

        //Student
        public string Index { get; set; }
        public DateTime ValidUntil { get; set; }
        public Faculty Faculty { get; set; }
        public int BreakfastCount { get; set; }
        public int LunchCount { get; set; }
        public int DinnerCount { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string FacultyDisplay => (Faculty != null) ? Faculty.Name : "/";

        public User()
        {
            UserPrivilegeses = new List<UserPrivileges>();
        }
    }
}
