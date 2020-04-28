using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozásProjeckt
{
    abstract class Munkások
    {
        public abstract string fizikum();
        public abstract string iq();

    }
    class FizikaiMunkás : Munkások
    {
        public override string fizikum()
        {
            return "Erős fizikumú!"; 
        }
        public override string iq()
        {
            return "Átlagos intelligencia szint!";
        }
    }
    class SzellemiMunkás : Munkások
    {
        public override string fizikum()
        {
            return "Gyenge fizikumú!";
        }
        public override string iq()
        {
            return "Átlagon felüli intelligencia szint!";
        }
    }
}
