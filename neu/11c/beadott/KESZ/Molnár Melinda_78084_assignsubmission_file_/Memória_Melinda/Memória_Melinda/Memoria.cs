using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memória_Melinda
{
    abstract class Memoria
    {
        public int Tarolokap { get; private set; }
        public string Kategoria { get; private set; }
        public string Torles { get; private set; }
        public string Felejtes { get; private set; }
        public string Sebesseg { get; private set; }
        public string Ar { get; private set; }


        protected Memoria(int tarolokap, string kategoria, string torles, string felejtes, string sebesseg, string ar)
        {
            Tarolokap = tarolokap;
            Kategoria = kategoria;
            Torles = torles;
            Felejtes = felejtes;
            Sebesseg = sebesseg;
            Ar = ar;
        }

        public static Memoria Factory(string tipus, int tarolokap, string kategoria, string torles, string felejtes, string sebesseg, string ar)
        {
            switch (tipus)
            {
               case "SRAM": return new RAM(tarolokap,kategoria,torles,felejtes,sebesseg,ar);
               case "DRAM": return new RAM(tarolokap, kategoria, torles, felejtes, sebesseg, ar);
               case "PROM": return new ROM(tarolokap, kategoria, torles, felejtes, sebesseg, ar);
               case "EPROM": return new ROM(tarolokap, kategoria, torles, felejtes, sebesseg, ar);
               default: throw new Exception("Nincs ilyen fajta a memóriában");
            }
        }
        public override string ToString()
        {
            return $"{GetType().Name},{Tarolokap},{Kategoria},{Torles},{Felejtes},{Sebesseg},{Ar}";
        }

        public static Memoria operator +(Memoria memoria)
        {
            return Factory(memoria.GetType().Name,memoria.Tarolokap,memoria.Kategoria,memoria.Torles,memoria.Felejtes,memoria.Sebesseg,memoria.Ar);
        }


    }
        
    }
