using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulyokDániel_11c_Projekt
{
    abstract class Ososztaly
    {
        public Ososztaly(int ertek)
        { }
        public int konyvertek
        {
            get;
            set;
        }
        public int filmertek
        {
            get;
            set;
        }
        public static string datum = DateTime.Today.ToString();
    }
}
