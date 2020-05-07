using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulyokDániel_11c_Projekt
{
    class Filmek : Ososztaly
    {
        public static int filmertek = 1000;
        public Filmek(int ertek) : base(ertek)
        {
            ertek = filmertek;
        }
    }

}
