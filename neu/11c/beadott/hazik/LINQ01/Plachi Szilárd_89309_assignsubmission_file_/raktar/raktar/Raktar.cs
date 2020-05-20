using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace raktar
{
    class Raktar
    {     
        public Raktar(string név,double myniseg,int ár)
        {
            Név = név;
            Menyiseg = myniseg;
            Ár = ár;
        }

        public static List<Raktar> beolvasas()
        {
            List<Raktar> raktars = new List<Raktar>(); 
            StreamReader olvas = new StreamReader("raktar.txt");
            while(!olvas.EndOfStream)
            {
                string[] darabok = olvas.ReadLine().Split(';');
                raktars.Add(new Raktar(darabok[0], double.Parse(darabok[1]), int.Parse(darabok[2])));

            }
            return raktars;
        }
        
        public string Név { get; set; }

        public double Menyiseg { get; set; }

        public int Ár { get; set; }
    }
}
