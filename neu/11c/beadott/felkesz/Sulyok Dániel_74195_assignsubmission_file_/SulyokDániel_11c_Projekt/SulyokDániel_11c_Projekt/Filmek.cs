using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulyokDániel_11c_Projekt
{
    abstract class Ososztaly
    { 
        public int Ertek { get; set; }
        public Ososztaly(int ertek)
        {
            this.Ertek = ertek;
        }
        public static string datum = DateTime.Today.ToString();
    }
    class Filmek : Ososztaly
    {
        public int filmertek { get; set; }
        public Filmek(int ertek) : base(ertek)
        {
        }
    }

}
