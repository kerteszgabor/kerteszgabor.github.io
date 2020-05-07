using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Warrior : Heroes
    {
        public Warrior(int tap, string nev) : base(tap, nev)
        {

        }

        public override int Tamadas
        {
            get
            {
                return (Tapasztalat * 4) / 3;
            }
        }

        public override string ToString()
        {
            return "Warrior " + Nev + " " + Tapasztalat+Szint+Tamadas;
        }
    }
}
