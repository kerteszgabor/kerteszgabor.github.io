using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schvorczi_Gergő_Projekt
{
    class Windows : Oprendszer
    {
        public Windows(int ram, string cpu, string gpu, string bit, string rendszer) : base(ram, cpu, gpu, rendszer, bit)
        {
        }
        
        public override string Kikapcsolas()
        {
            return "Ki fogok kapcsolni!";
        }

        public override double ProgramokSzama(double pszam)
        {
            return pszam * 2;
        }

        public override string Uzenet()
        {
            return "Jó napot felhasználó, ez itt a Windows!";
        }
    }
}
