using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szabó_Richárd_Projekt
{
    //Assault Rifle class
    class Bulldog : Weapons
    {
        public Bulldog()
        {      
            fejsebzes = 116;
            testsebzes = 35;
            labsebzes = 30;
            tarmeret = 30;
            firerate = 13.33;
            creds = 1600;
            nev = "Bulldog";
        }
        public override string Mode()
        {
            return "Full-automatic";
        }
        public override string KepPath { get; set; } = "Bulldog Assault Rifle.png";
    }
    class Guardian : Weapons
    {
        public Guardian()
        {
            fejsebzes = 195;
            testsebzes = 65;
            labsebzes = 49;
            tarmeret = 12;
            firerate = 6.5;
            creds = 2700;
            nev = "Guardian";
        }
        public override string Mode()
        {
            return "Semi-automatic";
        }
        public override string KepPath { get; set; } = "Guardian Assault Rifle.png";
    }
    class Phantom : Weapons
    {
        public Phantom()
        {
            tarmeret = 30;
            firerate = 11;
            creds = 2900;
            nev = "Phantom";
        }
        public override string Mode()
        {
            return "Full-automatic";
        }
        public override string KepPath { get; set; } = "Phantom Assault Rifle.png";
        public override int Fejsebzes 
        {
            get
            {
                if (tavolsag>0 && tavolsag<15)
                {
                    return 156;
                }
                else if (tavolsag>=15 && tavolsag<30)
                {
                    return 140;
                }
                else
                {
                    return 124;
                }
            }        
        }
        public override int Testsebzes
        {
            get
            {
                if (tavolsag > 0 && tavolsag < 15)
                {
                    return 39;
                }
                else if (tavolsag >= 15 && tavolsag < 30)
                {
                    return 35;
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
                if (tavolsag > 0 && tavolsag < 15)
                {
                    return 33;
                }
                else if (tavolsag >= 15 && tavolsag < 30)
                {
                    return 30;
                }
                else
                {
                    return 26;
                }
            }
        }

    }
    class Vandal : Weapons
    {
        public Vandal()
        {
            fejsebzes = 156;
            testsebzes = 39;
            labsebzes = 33;
            tarmeret = 25;
            firerate = 9.25;
            creds = 2900;
            nev = "Vandal";
        }
        public override string Mode()
        {
            return "Full-automatic";
        }
        public override string KepPath { get; set; } = "Vandal Assault Rifle.png";
    }
}
