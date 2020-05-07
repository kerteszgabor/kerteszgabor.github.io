using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    public abstract class Heroes 
    {
        static Random r = new Random();

        public abstract int Tamadas { get; }
        public int Tapasztalat{ get; private set; }
        public int Vedekezes { get; private set; }
        public int Szint { get; private set; }
        public string Kepessegek { get; private set; }
        public string Nev { get; private set; }

        private int TamadasM
        {
            get
            {
                return Tamadas + r.Next(Math.Max(50, Tamadas));
            }
        }

        protected Heroes(int tap, string nev)
        {
            this.Tapasztalat = tap;
            this.Nev = nev;
        }

        public static Heroes Factory(string onev, string nev, int tap)
        {
            if (onev == "Guardian")
            {
                return new Guardian(tap, nev);
            }
            if (onev == "Warrior")
            {
                return new Warrior(tap, nev);
            }
            if (onev == "Berserker")
            {
                return new Berserker(tap, nev);
            }
            throw new Exception("Nincs ilyen lény " + onev);
        }

     

        public int Megkuzd(Heroes s)
        {
            return TamadasM.CompareTo(s.TamadasM);

        }

        public abstract override string ToString();
                                
    }
}

