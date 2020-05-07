using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szabó_Richárd_Projekt
{
    //Heavy class
    class Ares : Weapons
    {
        public Ares()
        {
            tarmeret = 50;
            firerate = 10;
            creds = 1700;
            nev = "Ares";
        }
        public override string Mode()
        {
            return "Full-automatic";
        }
        public override string KepPath { get; set; } = "Ares Heavy.png";
        public override int Fejsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 72;
                }
                else
                {
                    return 67;
                }
            }
        }
        public override int Testsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 30;
                }
                else
                {
                    return 28;
                }
            }
        }
        public override int Labsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 25;
                }
                else
                {
                    return 23;
                }
            }
        }
    }
    class Odin : Weapons
    {
        public Odin()
        {
            tarmeret = 100;
            firerate = 12;
            creds = 3200;
            nev = "Odin";
        }
        public override string Mode()
        {
            return "Full-automatic";
        }
        public override string KepPath { get; set; } = "Odin Heavy.png";
        public override int Fejsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 95;
                }
                else
                {
                    return 77;
                }
            }
        }
        public override int Testsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 38;
                }
                else
                {
                    return 31;
                }
            }
        }
        public override int Labsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 32;
                }
                else
                {
                    return 26;
                }
            }
        }
    }
}
