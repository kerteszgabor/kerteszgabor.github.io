using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egbomon_Michael_11b_Projekt_Hotel
{
    class Vendeg
    {
        protected string nev;
        protected int kor;
        protected int napok;
        

        public Vendeg(string nev, int kor, int napok)
        {
            this.nev = nev;
            this.kor = kor;
            this.napok = napok;
        }

        public string Informacio()
        {
            return "\n\tAz új vendég adatai:\nVendég neve: " + nev + "\nVendég életkora: " + kor +
                "\nSzállodában kívánt tartózkodási napok száma: " + napok;            
        }
    }
}
