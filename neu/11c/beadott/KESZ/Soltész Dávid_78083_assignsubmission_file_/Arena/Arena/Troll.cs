using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Troll : Szorny
    {
        public Troll(int tap, string nev) : base(tap, nev)
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
            return "Troll " + Nev + " " + Tapasztalat;
        }
    }
}
