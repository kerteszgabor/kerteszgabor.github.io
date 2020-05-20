using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace raktar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Raktar> rakter = Raktar.beolvasas();
            Console.WriteLine("hali gabi amit még le adtam projektett az 1-es vagy még rá fogsz majd nézni?");
            var kbetu = rakter.Where(x => x.Név.StartsWith("k"));
            kbetu.ForEach(i=>Console.WriteLine($"k batüvel kezdődik {i.Név}"));
            var legdragabb = rakter.Max(x=>x.Ár);
            Console.WriteLine($"Legdrágább: {legdragabb}");
            var melyikalegdragabb = rakter.Find(x => x.Ár==legdragabb);
            Console.WriteLine($"A legdrágáb neve : {melyikalegdragabb.Név}");
            var osszertek = rakter.Sum(x => x.Menyiseg * x.Ár);
            Console.WriteLine($"a raktár öszértéke: {osszertek}");
            var abc = rakter.OrderBy(x => x.Név);
            Console.WriteLine("ABC SOREND");
            abc.ForEach(i => Console.WriteLine(i.Név));
            Console.ReadKey();


        }
    }
}
