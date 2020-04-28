using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportautok
{
    abstract class Sportautok
    {
        protected double ar;
        protected int ev;
        protected int tomeg;
        protected double teljesitm;
        protected int darab;

        public Sportautok(double ar, int ev, int tomeg, double teljesitm, int darab)
        {
            this.ar = ar;
            this.ev = ev;
            this.tomeg = tomeg;
            this.teljesitm = teljesitm;
            this.darab = darab;
        }

        public double Ar { get; set; }
        public int Ev { get; set; }
        public int Tomeg { get; set; }
        public double Teljesitm { get; set; }
        public int Darab { get; set; }
      

        
    }
}
