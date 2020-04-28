using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Race[] fajok = {new Human(),new Mermaid() };
            Classes[] kasztok = { new Mage(), new Thief() };
            List<Race> races = new List<Race>(fajok);
            List<Classes> classes = new List<Classes>(kasztok);

            List<Character> characters = new List<Character>();
            Console.Write("Ez a program csak egy vázlat verziója egy teljeskörű Dungeons and Dragons 5. kiadásában szereplő karakterkezelő programnak (csak szemléltetésképpen van 2 faj és 2 kaszt).\nÚJ karakter: newchar\nMegnyitás: openchar\nKarakterek listája: ls\nAktív karakterlista elmentése egy fájlba: save\nKaraktelista betöltése fájlból: load\n");
            
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "newchar":
                        Console.WriteLine("Adja meg a karakter nevét!");
                        string name = Console.ReadLine().Split(';')[0];
                        Console.WriteLine("Válassza ki a karakter faját!");
                        List<string> vs = new List<string>();
                        List<string> vs1 = new List<string>();

                        foreach (var item in races)
                        {
                            Console.WriteLine(item.Name);
                            vs.Add(item.Name);
                        }
                        string x = Console.ReadLine();
                        if (vs.Contains(x))
                        {
                            Console.WriteLine("Válasszon ki egy kasztot!");

                            foreach (var item in classes)
                            {
                                Console.WriteLine(item.Name);
                                vs1.Add(item.Name);
                            }
                            string y = Console.ReadLine();
                            if (vs1.Contains(y))
                            {
                                Console.WriteLine("Mivel foglalkozik a karaktere? (Mesterség, Hobbi, Munka) pl:Szakács vagy Bűnöző");
                                string j = Console.ReadLine().Split(';')[0];
                                Character newchar = new Character(j, races[vs.IndexOf(x)], classes[vs1.IndexOf(y)], name);
                                characters.Add(newchar);
                            }
                        }
                        else { Console.WriteLine("Hiba, nincs ilyen faj!"); }
                        break;
                    case "openchar": Console.WriteLine("Adja meg a karaktere nevét!");

                        string openname = Console.ReadLine();
                        Character character = characters.Find(t => t.Name.Equals(openname));
                        if (characters.Contains(character))
                        {


                            string line = "";
                            Console.WriteLine("Elérhető parancsok: strcheck, wsdcheck, chrcheck, spells, exit, raceability");
                            while (line != "exit")
                            {
                                line = Console.ReadLine();
                                switch (line)
                                {
                                    case "strcheck":
                                        Console.WriteLine($"A dobás eredménye: {character.StrengthCheck()}");
                                        break;

                                    case "wsdcheck":
                                        Console.WriteLine($"A dobás eredménye: {character.WisdomCheck()}");
                                        break;

                                    case "chrcheck":
                                        Console.WriteLine($"A dobás eredménye: {character.CharismaCheck()}");
                                        break;
                                    case "spells":
                                        string spellz = "A megtanult varázslatok: ";
                                        foreach (var item in character.Spells)
                                        {
                                            spellz += item + ", ";
                                        }
                                        Console.WriteLine(spellz);
                                        break;
                                    case "raceability":
                                        Console.WriteLine("Kire használja a képességét a karaktere?");
                                        string target = Console.ReadLine();
                                        character.RaceAbility(characters.Find(t => t.Name == target));
                                        break;
                                    default:
                                        if (line != "exit") { Console.WriteLine("Hiba, nincs ilyen parancs"); }
                                        break;
                                }
                            }
                        }
                        else { Console.WriteLine("NIncs ilyen karakter!"); }
                        break;
                    case "ls":
                        Console.WriteLine("Karakterek listája: ");
                        foreach (var item in characters)
                        {
                            Console.WriteLine($"{item.Name}, a(z) {item.job} aki egy {item.Kaszt}");
                        }
                        break;
                    case "save":
                        Console.WriteLine("Kérem adja meg a betöltendő fájl nevét! (kiterjesztés nélkül)");
                        string filename = Console.ReadLine() + ".txt";
                        StreamWriter writer = new StreamWriter(File.OpenWrite(filename));
                        writer.AutoFlush = false;
                        writer.Write("");
                        writer.AutoFlush = true;
                        foreach (var item in characters)
                        {
                            writer.WriteLine($"{item.Name};{item.Kaszt};{item.job};{item.Race}");
                        }

                        writer.Close();
                        break;
                    case "load":
                        Console.WriteLine("Kérem adja meg a betöltendő fájl nevét! (kiterjesztés nélkül)\nDISCLAIMER: Minden nem mentett munka el fog veszni (visszalépéshez adjon meg egy nem létező fáljnevet)");
                        string filename2 = Console.ReadLine() + ".txt";
                        if (File.Exists(filename2))
                        {
                            StreamReader reader = File.OpenText(filename2);
                            characters.Clear();
                            while (!reader.EndOfStream)
                            {
                                string[] sor = reader.ReadLine().Split(';');
                                characters.Add(new Character(sor[2],races.Find(t=>t.Name==sor[3]),classes.Find(t=>t.Name==sor[1]),sor[0]));
                            }

                            reader.Close();
                        }
                        else { Console.WriteLine("Hiba: nincs ilyen fájl"); }
                        break;
                    default: Console.WriteLine("Nincs ilyen parancs!");
                        break;
                }
            }
        }
    }
}
