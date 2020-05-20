using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Tartalmak
    {
        private string nev;
        private double mennyiseg;
        private int egysegar;

        public string Nev
        {
           
            set { Nev = nev; }
            get { return nev; }
            
        }
        public double Mennyiseg
        {

            set { Mennyiseg = mennyiseg; }
            get { return mennyiseg; }

        }
        public int Egysegar
        {

            set { Egysegar = egysegar; }
            get { return egysegar; }

        }

        public Tartalmak(string x, double y, int z)
        {
            nev = x;
            mennyiseg = y;
            egysegar = z;
        }   
    }
}
