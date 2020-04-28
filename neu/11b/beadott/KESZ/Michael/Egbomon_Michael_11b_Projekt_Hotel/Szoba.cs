using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egbomon_Michael_11b_Projekt_Hotel
{
    abstract class Szoba
    {
        protected double terulet;
        protected bool etkezes;

        protected Szoba(double terulet, bool etkezes)
        {
            this.terulet = terulet;
            this.etkezes = etkezes;
        }

        public abstract string Tipus();

        public abstract double Meret();
    }
}
