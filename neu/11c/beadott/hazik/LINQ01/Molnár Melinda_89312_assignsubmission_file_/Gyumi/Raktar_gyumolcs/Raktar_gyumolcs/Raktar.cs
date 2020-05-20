using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar_gyumolcs
{
    class Raktar
    {
        public string Gynev { get; set; }
        public double Mennyiseg { get; set; }
        public int Egysegar { get; set; }

        public override string ToString()
        {
            return $"{Gynev}, {Mennyiseg}, {Egysegar}";
        }
    }

    
}
