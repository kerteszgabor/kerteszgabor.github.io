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
            mode = "Full-automatic";
        }
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
            mode = "Semi-automatic";
        }
    }
    class Phantom : Weapons
    {
        public Phantom()
        {
            if (tavolsag > 0 && tavolsag < 15)
            {
                fejsebzes = 156;
                testsebzes = 39;
                labsebzes = 33;
            }
            else if (tavolsag >=15 && tavolsag<30)
            {
                fejsebzes = 140;
                testsebzes = 35;
                labsebzes = 30;
            }
            else
            {
                fejsebzes = 124;
                testsebzes = 31;
                labsebzes = 26;
            }
            tarmeret = 30;
            firerate = 11;
            creds = 2900;
            mode = "Full-automatic";
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
            mode = "Full-automatic";
        }
    }
}
