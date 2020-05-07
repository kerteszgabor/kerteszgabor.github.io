using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szabó_Richárd_Projekt
{
    //Smg class
    class Stinger : Weapons
    {
        public Stinger()
        {
            tarmeret = 20;
            firerate = 18;
            creds = 1000;
            nev = "Stinger";
        }
        public override string Mode()
        {
            return "Full-automatic";
        }
        public override string KepPath { get; set; } = "Stinger SMG.png";
        public override int Fejsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 20)
                {
                    return 67;
                }
                else
                {
                    return 62;
                }
            }
        }
        public override int Testsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 20)
                {
                    return 27;
                }
                else
                {
                    return 25;
                }
            }
        }
        public override int Labsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 20)
                {
                    return 23;
                }
                else
                {
                    return 21;
                }
            }
        }
    }
    class Spectre : Weapons
    {
        public Spectre()
        {
            tarmeret = 30;
            firerate = 13.33;
            creds = 1600;
            nev = "Spectre";
        }
        public override string Mode()
        {
            return "Full-automatic";
        }
        public override string KepPath { get; set; } = "Spectre SMG.png";
        public override int Fejsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 20)
                {
                    return 78;
                }
                else
                {
                    return 66;
                }
            }
        }
        public override int Testsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 20)
                {
                    return 26;
                }
                else
                {
                    return 22;
                }
            }
        }
        public override int Labsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 20)
                {
                    return 22;
                }
                else
                {
                    return 18;
                }
            }
        }
    }
}
