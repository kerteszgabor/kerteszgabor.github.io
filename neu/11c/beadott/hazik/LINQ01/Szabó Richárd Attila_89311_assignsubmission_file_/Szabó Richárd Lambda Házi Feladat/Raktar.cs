using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szabó_Richárd_Lambda_Házi_Feladat
{
    class Raktar
    {
        public string gyumolcsnev;
        public double mennyiseg;
        public int egysegar;

        public Raktar(string gyumolcsnev, double mennyiseg, int egysegar)
        {
            this.gyumolcsnev = gyumolcsnev;
            this.mennyiseg = mennyiseg;
            this.egysegar = egysegar;
        }

        public override string ToString()
        {
            return $"Név: {gyumolcsnev}, Mennyiség: {mennyiseg}kg, Egysegár: {egysegar} Ft/kg.";
        }   
    }
}
