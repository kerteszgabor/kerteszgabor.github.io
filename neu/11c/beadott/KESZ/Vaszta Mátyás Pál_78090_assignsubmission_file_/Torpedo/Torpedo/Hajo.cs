using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    class Tabla
    {
        private int [,] felulet = new int [10, 10];
        private int[,] hajo = new int[10, 10];

        public Tabla()
        {
            for(int i=0;i<10;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    felulet[i, j] = 0;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    hajo[i, j] = 0;
                }
            }
        }

       

       
    }


    class Hajo 
    {
        
        protected int fugoleges;
        //0 - felfele
        //1 - ballra
        //2 - lefele
        //3 - jobbra
      
        protected int x;
        //betűs koordináta
        protected int y;
        //számos koordináta
        public Tabla Tabla = new Tabla();

        public Hajo(int X, int Y, int Fugoleges)
        {
            x = X;
            y = Y;
            fugoleges = Fugoleges;
            

        }
        public static Hajo Factory(string osztalynev, int x,int y, int Fugoleges)
        {
            switch(osztalynev)
            {
                case "Naszád": return new Naszad(x, y, Fugoleges);
                case "Romboló": return new Rombolo(x, y, Fugoleges);
                case "Submarine": return new Submarine(x, y, Fugoleges);
                case "Hordozó": return new Hordozo(x, y, Fugoleges);
                default:return null;
                    break;
            }
        }


    }
    class Naszad : Hajo
    {
        public Naszad(int x, int y, int fugoleges): base(x,y,fugoleges)
        {
          
        }

    }
    class Rombolo : Hajo
    {
        public Rombolo(int x, int y, int fugoleges) : base(x, y, fugoleges)
        {
           
        }

    }
    class Submarine : Hajo
    {
        public Submarine(int x, int y, int fugoleges) : base(x, y, fugoleges)
        {
           
        }

    }
    class Hordozo : Hajo
    {
        public Hordozo(int x, int y, int fugoleges) : base(x, y, fugoleges)
        {
           
        }

    }


}
