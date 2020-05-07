using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    public abstract class Szorny //: IComparable<Szorny>
    {
        static Random r = new Random();

        public abstract int Tamadas { get; }
        public int Tapasztalat { get; private set; }
        public string Nev { get; private set; }

        private int TamadasErtek
        {
            get
            {
                return Tamadas + r.Next(Math.Max(10, Tamadas));
            }
        }

        protected Szorny(int tap, string nev)
        {
            this.Tapasztalat = tap;
            this.Nev = nev;
        }

        public static Szorny Factory(string onev, string nev, int tap)
        {
            if (onev == "Ogre")
            {
                return new Ogre(tap, nev);
            }
            if (onev == "Ork")
            {
                return new Ork(tap, nev);
            }
            if (onev == "Troll")
            {
                return new Troll(tap, nev);
            }
            throw new Exception("Nem hozható létre a szörny: " + onev);
        }

     /*   public int CompareTo(Szorny s)
        {
            
        } */

        public int Megkuzd(Szorny s)
        {
            return TamadasErtek.CompareTo(s.TamadasErtek);

        }

        public abstract override string ToString();
                                
    }
}

