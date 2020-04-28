using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schvorczi_Gergő_Projekt
{
    abstract class Oprendszer
    {
        protected string rendszer;
        protected int ram;
        protected string cpu;
        protected string gpu;
        protected string bit;

        protected Oprendszer(int ram, string cpu, string gpu, string rendszer, string bit)
        {
            this.ram = ram;
            this.cpu = cpu;
            this.gpu = gpu;
            this.rendszer = rendszer;
            this.bit = bit;
        }

        public int Ram
        {
            get { return ram; }
        }

        public string Cpu
        {
            get { return cpu; }
        }

        public string Gpu
        {
            get { return gpu; }
        }

        public string Rendszer
        {
            get { return rendszer; }
        }

        public string Bit
        {
            get { return bit; }
        }

        public abstract string Uzenet();
        public abstract string Kikapcsolas();
        public abstract double ProgramokSzama(double pszam);

    }
}

