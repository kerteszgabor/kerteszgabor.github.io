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
            if (tavolsag > 0 && tavolsag < 20)
            {
                fejsebzes = 67;
                testsebzes = 27;
                labsebzes = 23;
            }
            else
            {
                fejsebzes = 62;
                testsebzes = 25;
                labsebzes = 21;
            }
            tarmeret = 20;
            firerate = 18;
            creds = 1000;
            mode = "Full-automatic";
        }
    }
    class Spectre : Weapons
    {
        public Spectre()
        {
            if (tavolsag > 0 && tavolsag < 20)
            {
                fejsebzes = 78;
                testsebzes = 26;
                labsebzes = 22;
            }
            else
            {
                fejsebzes = 66;
                testsebzes = 22;
                labsebzes = 18;
            }
            tarmeret = 30;
            firerate = 13.33;
            creds = 1600;
            mode = "Full-automatic";
        }
    }
}
