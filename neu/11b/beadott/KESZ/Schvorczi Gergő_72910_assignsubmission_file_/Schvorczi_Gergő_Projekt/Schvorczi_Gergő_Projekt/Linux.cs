using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schvorczi_Gergő_Projekt
{
    class Linux : Oprendszer
    {
        public Linux(int ram, string cpu, string gpu, string bit, string rendszer) : base(ram, cpu, gpu, rendszer, bit)
        {
        }

        public override string Kikapcsolas()
        {
            return "De ugye majd visszakapcsolsz?";
        }

        public override double ProgramokSzama(double pszam)
        {
            return pszam;
        }

        public override string Uzenet()
        {
            return "Helló, ez itt a Linux!";
        }
    }
}
