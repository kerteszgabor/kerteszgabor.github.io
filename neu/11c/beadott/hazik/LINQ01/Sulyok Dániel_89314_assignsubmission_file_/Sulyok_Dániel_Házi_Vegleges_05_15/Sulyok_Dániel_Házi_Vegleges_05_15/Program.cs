using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sulyok_Dániel_Házi_Végleges
{
    class Raktar
    {
        public string gynev;
        public double mennyiseg;
        public int egysegar;

        public Raktar(string gyumolcsnev, double kg, int ar)
        {
            gynev = gyumolcsnev;
            mennyiseg = kg;
            egysegar = ar;
        }

        public override string ToString()
        {
            return $"Gyümölcs neve: {gynev}, mennyiség (kg): {mennyiseg}kg, egységár (ft): {egysegar} ft/kg.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Raktar> lista = new List<Raktar>();
            if (File.Exists("raktar.txt"))
            {
                StreamReader be = new StreamReader("raktar.txt");
                while (!be.EndOfStream)
                {
                    string sor = be.ReadLine();
                    string[] darab = sor.Split(';');
                    Raktar h = new Raktar(darab[0], Convert.ToDouble(darab[1]), int.Parse(darab[2]));
                    lista.Add(h);
                }
            }



            // K BETŰVEL KEZDŐDŐ
            Console.WriteLine("Első feladat:");
            int kbetu = lista.Where(x => x.gynev.StartsWith("k")).Count();
            Console.WriteLine($"Összesen {kbetu} gyümölcs kezdődik k betűvel.");



            // LEGDRÁGÁBB GYÜMÖLCS ÁRA
            Console.WriteLine("\nMásodik feladat:");
            int maxar = lista.Max(x => x.egysegar);
            var dragagyumolcs = lista.Find(x => x.egysegar == maxar);
            Console.WriteLine($"Legdrágább gyümölcs ára: {dragagyumolcs.egysegar}");



            // MELYIK A LEGDRÁGÁBB GYÜMÖLCS
            Console.WriteLine("\nHarmadik feladat:");
            Console.WriteLine($"Legdrágább gyümölcs neve: {dragagyumolcs.gynev}");



            // RAKTÁRNAK AZ ÖSSZÉRTÉKE
            Console.WriteLine("\nNegyedik feladat:");

            double osszertek = lista.Sum(x => x.mennyiseg * x.egysegar);
            Console.WriteLine($"A raktár összesen {osszertek} forintot ér.");

            Console.WriteLine(" \nÖtödik feladat, az áruk listája: \n");



            // ABC SORREND
            var beturend = lista.OrderBy(x => x.gynev);
            foreach (var item in beturend)
            {
                Console.WriteLine(item.ToString());
            }



            Console.ReadLine();
        }
    }
}