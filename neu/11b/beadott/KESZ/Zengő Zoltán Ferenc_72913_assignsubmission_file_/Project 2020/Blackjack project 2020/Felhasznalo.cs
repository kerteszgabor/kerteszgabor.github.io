using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_project_2020
{
    class Felhasznalo
    {                
        public string Felhasznalonev;
        public string Jelszo;
        public int Zseton;
        public string Kartyaszam;
        public string Lejarat;
        public int Cvc;
        public int Egyenleg;
        public string Email;
       
        public Felhasznalo(string felhasznalonev, string jelszo, int zseton, string kartyaszam, string lejarat, int cvc, int egyenleg, string email)
        { 
            Felhasznalonev = felhasznalonev;
            Jelszo = jelszo;
            Zseton = zseton;
            Kartyaszam = kartyaszam;
            Lejarat = lejarat;
            Cvc = cvc;
            Egyenleg = egyenleg;
            Email = email;

        }       
    }
    class Member : Felhasznalo
    {
        public Member(string Felhasznalonev, string Jelszo, int Zseton, string Kartyaszam, string Lejarat, int Cvc, int Egyenleg, string Email) : base(Felhasznalonev, Jelszo, Zseton, Kartyaszam, Lejarat, Cvc, Egyenleg, Email)
        {
        }
    }
}
