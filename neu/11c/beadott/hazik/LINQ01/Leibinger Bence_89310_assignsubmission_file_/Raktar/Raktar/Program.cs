using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Tartalmak> raktar = new List<Tartalmak>();
            using (StreamReader fbe = new StreamReader("raktar.txt"))
            {
                while (!fbe.EndOfStream)
                {
                    string[] tores = fbe.ReadLine().Split(';');
                    string neve = tores[0];
                    double mennyisege = Convert.ToDouble(tores[1]);
                    int egysegara = Convert.ToInt32(tores[2]);
                    Tartalmak aru = new Tartalmak(neve, mennyisege, egysegara);
                    raktar.Add(aru);
                }
            }
            int kbetu = 0;
            int legdragabb = 0;
            string legdragabbnev = "";
            double osszertek = 0;
            foreach (Tartalmak elemek in raktar)
            {

                if (elemek.Egysegar>legdragabb)
                {
                    legdragabb = elemek.Egysegar;
                    legdragabbnev = elemek.Nev;
                }
                if (elemek.Nev.StartsWith("k"))
                {
                    kbetu++;
                }
                osszertek += elemek.Egysegar * elemek.Mennyiseg;
            }
            IOrderedEnumerable<Tartalmak> rendezett;
            rendezett = raktar.OrderBy(Tartalmak => Tartalmak.Nev);
            Console.WriteLine("1. Feladat: " + kbetu.ToString() + "db k betűs");
            Console.WriteLine("2. Feladat: " + legdragabb.ToString() + "ft-ba kerül");
            Console.WriteLine("3. Feladat: a(z) " + legdragabbnev + " a legdrágább");
            Console.WriteLine("4. Feladat: a raktár összértéke: " + osszertek.ToString() + "ft");
            Console.WriteLine("5. Feladat: ");
            foreach (Tartalmak elem in rendezett)
            {
                Console.WriteLine("            "+elem.Nev +"; "+ elem.Mennyiseg.ToString() +" db; "+ elem.Egysegar.ToString()+" ft/db");
            }
            Console.ReadKey();
        }
        
        
    }
}
