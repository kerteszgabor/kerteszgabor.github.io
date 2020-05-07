using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Guardian : Heroes
    {
        public Guardian(int tap, string nev) : base(tap, nev)
        {

        }

        public override int Tamadas
        {
            get
            {
                return Tapasztalat * 2;
            }
        }

        public override string ToString()
        {
            return "Guardian " + Nev + " " + Tapasztalat + Szint + Tamadas;
        }
    }
}
