using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Berserker : Heroes
    {
        public Berserker(int tap, string nev) : base(tap, nev)
        {
        }

        public override int Tamadas
        {
            get
            {
                return Tapasztalat * 3;
            }
        }
        public override string ToString()
        {
            return "Berserker " + Nev + " " + Tapasztalat + Szint + Tamadas;
        }
    }
}
