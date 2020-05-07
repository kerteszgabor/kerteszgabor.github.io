using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szabó_Richárd_Projekt
{
    //Pistol class
    class Classic : Weapons
    {
        public Classic()
        {
            tarmeret = 12;
            firerate = 6.75;
            creds = 0;
            nev = "Classic";
        }
        public override string Mode()
        {
            return "Semi-automatic";
        }
        public override string KepPath { get; set; } = "Classic Pistol.png";
        public override int Fejsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
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
                if (tavolsag > 0 && tavolsag < 30)
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
                if (tavolsag > 0 && tavolsag < 30)
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
    class Frenzy : Weapons
    {
        public Frenzy()
        {
            tarmeret = 13;
            firerate = 10;
            creds = 400;
            nev = "Frenzy";
        }
        public override string Mode()
        {
            return "Full-automatic";
        }
        public override string KepPath { get; set; } = "Frenzy Pistol.png";
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
                    return 63;
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
                    return 21;
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
                    return 17;
                }
            }
        }
    }
    class Ghost : Weapons
    {
        public Ghost()
        {
            tarmeret = 15;
            firerate = 6.75;
            creds = 500;
            nev = "Ghost";
        }
        public override string Mode()
        {
            return "Semi-automatic";
        }
        public override string KepPath { get; set; } = "Ghost Pistol.png";
        public override int Fejsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 105;
                }
                else
                {
                    return 88;
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
                    return 25;
                }
            }
        }
        public override int Labsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 26;
                }
                else
                {
                    return 21;
                }
            }
        }
    }
    class Sheriff : Weapons
    {
        public Sheriff()
        {
            tarmeret = 6;
            firerate = 4;
            creds = 800;
            nev = "Sheriff";
        }
        public override string Mode()
        {
            return "Semi-automatic";
        }
        public override string KepPath { get; set; } = "Sheriff pistol.png";
        public override int Fejsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 160;
                }
                else
                {
                    return 145;
                }
            }
        }
        public override int Testsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 55;
                }
                else
                {
                    return 50;
                }
            }
        }
        public override int Labsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 30)
                {
                    return 47;
                }
                else
                {
                    return 43;
                }
            }
        }

    }

}

