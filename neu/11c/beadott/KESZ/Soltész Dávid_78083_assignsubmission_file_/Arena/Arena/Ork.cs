using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Ork : Szorny
    {
        public Ork(int tap, string nev) : base(tap, nev)
        {

        }

        public override int Tamadas
        {
            get
            {
                return (Tapasztalat * 5) / 3;
            }
        }

        public override string ToString()
        {
            return "Ork " + Nev + " " + Tapasztalat;
        }
    }
}
