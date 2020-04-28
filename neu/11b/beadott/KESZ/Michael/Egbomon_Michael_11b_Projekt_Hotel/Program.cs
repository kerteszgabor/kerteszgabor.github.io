using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egbomon_Michael_11b_Projekt_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tKészítette: Egbomon Michael 11.b" +
          "\nEz a program egy szállodának a tranzakciós és a vendégek adatkezelési rendszerét fogja szimulálni.\n\n");

            List<Vendeg> vendegek = new List<Vendeg>();
            List<Szoba> szobakLista = new List<Szoba>();

            string Vnev;
            int Vkor;
            int Vnapok;
            double arOssz;


                //Vendég nevének a lekérése                
                Console.WriteLine("Kérem adja meg a nevét!");
                Vnev = Console.ReadLine();
                Console.WriteLine($"A megadott név : {Vnev} !\n");


            //Ellenőrzés hogy a felhasználó jól adta meg a nevét
             Console.WriteLine("\tHelyesen adta meg a nevét? \n" +
                  "Ha igen akkor kérem írja be hogy \"i\" vagy \"igen\" \n" +
                  "Ha nem akkor kérem hogy írja be hogy: \"n\" vagy \"nem\"");
                string EllNev = Console.ReadLine();
            
                if (EllNev == "n" || EllNev == "nem")
                {
                    Console.WriteLine("Kérem mégegyszer adja meg a nevét!");
                    Vnev = Console.ReadLine();
                    Console.WriteLine($"\nAz újonnal megadott név: {Vnev} !");

                }
                else if (EllNev == "i" || EllNev == "igen")
                {
                    Console.WriteLine("A nevét sikeresen rögzítettük!");
                }

            //Vendég életkorának a lekérése
            do
            {
                Console.WriteLine("\nKérem adja meg az életkorát!");
                Vkor = int.Parse(Console.ReadLine());

                if (Vkor < 18 || Vkor > 100)
                {
                    Console.WriteLine("Kérem helyes adatot adjon meg! \n" +
                        "Hibás adat: A megadott szám negatív, kisebb mint 18 vagy nagyobb mint 100!");
                }

            } while (!(Vkor >= 18 && Vkor <= 100));

                Console.WriteLine($"Az életkorát sikeresen rögzítettük!\n" +
                    $"A megadott életkor: {Vkor} !\n");


            //Vendég által kívánt tartózkodási napok számának a lekérése
            do
            {
            Console.WriteLine("\nKérem adja meg a szállodában kívánt tartózkodási nap/napok számát!");
                Vnapok = int.Parse(Console.ReadLine());

                if (Vnapok <= 0)
                {
                    Console.WriteLine("Kérem helyes adatot adjon meg!");
                }

            } while (!(Vnapok > 0));

            Console.WriteLine($"A megadott napok száma: {Vnapok} !\n");
            arOssz = 1000 * Vnapok;
            
            Vendeg UjVendeg = new Vendeg(Vnev, Vkor, Vnapok);
            vendegek.Add(UjVendeg);
            

            //Szoba választás
            Console.WriteLine("Kérem válasszon egy szoba típust és adja meg annak a kezdűbetűjét!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("<S> vagy <s> ~ Standard típusú szoba" +
                              "\n<V> vagy <v> ~ VIP (Superior) típusú szoba" +
                              "\n<B> vagy <b> ~ Business (Üzleti lakoszály) típusú szoba");
            Console.WriteLine("-------------------------------");
            string dontes = Console.ReadLine().ToUpper();

            switch (dontes)
            {
                case "S":
                    Console.WriteLine("\nA Standard típusú szobát választotta!");
                    Standard szobaS = new Standard(10, false);
                    szobakLista.Add(szobaS);
                    Console.WriteLine("\n\tA Standard szoba tulajdonságai");
                    Console.WriteLine($"Tájékoztató a szobáról: {szobaS.Tipus()}" +
                        $"\nA szoba területe: {szobaS.Meret()} m²");
                    arOssz += 500;
                    break;

                case "V":
                    Console.WriteLine("\nA VIP (Superior) típusú szobát választotta!");
                    VIP szobaV = new VIP(10, true);
                    szobakLista.Add(szobaV);
                    Console.WriteLine("\n\tA VIP szoba tulajdonságai");
                    Console.WriteLine($"Tájékoztató a szobáról: {szobaV.Tipus()}" +
                        $"\nA szoba területe: {szobaV.Meret()} m²");
                    arOssz += 1500;
                    break;

                case "B":
                    Console.WriteLine("\nA Business típusú szobát választotta!");
                    Business szobaB = new Business(10, true);
                    szobakLista.Add(szobaB);
                    Console.WriteLine("\n\tA Business szoba tulajdonságai");
                    Console.WriteLine($"Tájékoztató a szobáról: {szobaB.Tipus()}" +
                        $"\nA szoba területe: {szobaB.Meret()} m²");
                    arOssz += 3000;
                    break;

                default: Console.WriteLine("Rossz adat!"); break;
            }

            Console.WriteLine(UjVendeg.Informacio());
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\tSZÁMLA");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"A szolgáltatásokért összesen {arOssz} Ft-ot kell fizetni!");
            Console.WriteLine("-------------------------------");




            Console.WriteLine("\nA szimuláció végéhez értünk!\n\tViszlát! :)");
            Console.ReadKey();
        }
        
    }
}
