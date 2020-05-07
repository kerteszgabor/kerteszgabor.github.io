using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Devil: Demons
    {
        
        
            public Devil(int tap, string nev) : base(tap, nev)
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
                return "Devil " + Nev + " " + Tapasztalat + Vedekezes+ Szint;
            }
        
    }
}
