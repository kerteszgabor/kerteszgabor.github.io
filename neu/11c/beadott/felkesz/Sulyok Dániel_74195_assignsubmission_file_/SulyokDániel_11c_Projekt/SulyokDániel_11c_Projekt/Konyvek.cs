using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulyokDániel_11c_Projekt
{
    class Konyvek : Ososztaly
    {
        public static int konyvertek = 750;
        public Konyvek(int ertek) : base (ertek)
        {
            ertek = konyvertek;
        }
    }
}
