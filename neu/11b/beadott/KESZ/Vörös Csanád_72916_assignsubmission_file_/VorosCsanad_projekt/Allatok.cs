using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VorosCsanad_projekt
{
    class Allatok
    {
        public string osztaly { get; set; }
        public string nev { get; set; }
        public string elohely { get; set; }
        public int peldany { get; set; }
        public string KepPath { get; set; }
        public Allatok(string osztaly, string nev, string elohely, int peldany)
        {
            this.osztaly = osztaly;
            this.nev = nev;
            this.elohely = elohely;
            this.peldany = peldany;
        }
    }
}
