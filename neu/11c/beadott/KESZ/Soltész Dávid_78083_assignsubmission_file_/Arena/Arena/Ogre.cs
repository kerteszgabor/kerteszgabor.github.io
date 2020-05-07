using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Ogre : Szorny
    {
        public Ogre(int tap, string nev) : base(tap, nev)
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
            return "Ogre " + Nev + " " + Tapasztalat;
        }
    }
}
