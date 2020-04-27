using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
 
    class Hajo
    {
      
        protected bool fugoleges;
      
        protected int x;
        //betűs koordináta
        protected int y;
        //számos koordináta
       

        public Hajo(int X, int Y, bool Fugoleges)
        {
            x = X;
            y = Y;
            fugoleges = Fugoleges;

        }
        public static Hajo Factory(string osztalynev, int x,int y, bool Fugoleges)
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
        public Naszad(int x, int y, bool fugoleges): base(x,y,fugoleges)
        {

        }

    }
    class Rombolo : Hajo
    {
        public Rombolo(int x, int y, bool fugoleges) : base(x, y, fugoleges)
        {

        }

    }
    class Submarine : Hajo
    {
        public Submarine(int x, int y, bool fugoleges) : base(x, y, fugoleges)
        {

        }

    }
    class Hordozo : Hajo
    {
        public Hordozo(int x, int y, bool fugoleges) : base(x, y, fugoleges)
        {

        }

    }


}
