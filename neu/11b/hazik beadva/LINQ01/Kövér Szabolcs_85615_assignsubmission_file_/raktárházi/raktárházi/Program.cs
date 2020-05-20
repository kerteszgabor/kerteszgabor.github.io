using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace raktárházi
{

    class RaktárFeladat
    {

        static void Main(string[] args)
        {
            List<Raktár> rlist = new List<Raktár>();
            if (File.Exists("raktár.txt"))
            {
                StreamReader f = new StreamReader("raktár.txt");
                Raktár segéd = null;
                string[] darabol = f.ReadLine().Split(';');
                segéd = new Raktár();
                segéd.gyumolcsnev = darabol[0];
                segéd.mennyiség = Convert.ToDouble(darabol[1]);
                segéd.egységár = int.Parse(darabol[2]);
                rlist.Add(segéd);
            }

            var kbetu = rlist.Where(x => x.gyumolcsnev.StartsWith("k"));
            Console.WriteLine(kbetu);

            var drága = rlist.Max(x => x.egységár);
            Console.WriteLine(drága);

            var ossz = rlist.Sum(x => x.egységár * x.mennyiség);
            Console.WriteLine(ossz);

            var abc = rlist.OrderByDescending(x => x.gyumolcsnev);
            Console.WriteLine(abc);

            Console.ReadKey();
        }
    }

    class Raktár
    {
        public string gyumolcsnev { get; set; }
        public double mennyiség { get; set; }
        public int egységár { get; set; }
    }
}
