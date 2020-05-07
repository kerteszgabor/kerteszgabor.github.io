using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    
    
        class Nightmare : Demons
        {


            public Nightmare(int tap, string nev) : base(tap, nev)
            {
            }

            public override int Tamadas
            {
                get
                {
                    return Tapasztalat * 6;
                }
            }
            public override string ToString()
            {
                return "Nightmare " + Nev + " " + Tapasztalat + Vedekezes + Szint;
            }

        }
    
}
