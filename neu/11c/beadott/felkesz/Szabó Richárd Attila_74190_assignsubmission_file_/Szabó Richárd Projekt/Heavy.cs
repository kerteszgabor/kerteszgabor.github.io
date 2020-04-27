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
            if (tavolsag > 0 && tavolsag < 30)
            {
                fejsebzes = 72;
                testsebzes = 30;
                labsebzes = 25;
            }
            else
            {
                fejsebzes = 67;
                testsebzes = 28;
                labsebzes = 23;
            }
            tarmeret = 50;
            firerate = 10;
            creds = 1700;
            mode = "Full-automatic";
        }
    }
    class Odin : Weapons
    {
        public Odin()
        {
            if (tavolsag > 0 && tavolsag < 30)
            {
                fejsebzes = 95;
                testsebzes = 38;
                labsebzes = 32;
            }
            else
            {
                fejsebzes = 77;
                testsebzes = 31;
                labsebzes = 26;
            }
            tarmeret = 100;
            firerate = 12;
            creds = 3200;
            mode = "Full-automatic";
        }
    }
}
