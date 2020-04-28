using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schvorczi_Gergő_Projekt
{
    class MacOS : Oprendszer
    {
        public MacOS(int ram, string cpu, string gpu, string bit, string rendszer) : base(ram, cpu, gpu, rendszer, bit)
        {
        }

        public override string Kikapcsolas()
        {
            return "Most kikapcsoltál?:(";
        }

        public override double ProgramokSzama(double pszam)
        {
            return pszam * 3;
        }

        public override string Uzenet()
        {
            return "Üdvözöllek, ez itt a MacOS!:)";
        }
    }
}
