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
            if (tavolsag>0 && tavolsag<30)
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
            tarmeret = 12;
            firerate = 6.75;
            creds = 0;
            mode = "Semi-Automatic";
        }
    }
    class Frenzy : Weapons
    {
        public Frenzy()
        {
            if (tavolsag > 0 && tavolsag < 20)
            {
                fejsebzes = 78;
                testsebzes = 26;
                labsebzes = 22;
            }
            else
            {
                fejsebzes = 63;
                testsebzes = 21;
                labsebzes = 17;
            }
            tarmeret = 13;
            firerate = 10;
            creds = 400;
            mode = "Full-automatic";
            
        }
    }
    class Ghost : Weapons
    {
        public Ghost()
        {
            if (tavolsag > 0 && tavolsag < 30)
            {
                fejsebzes = 105;
                testsebzes = 30;
                labsebzes = 26;
            }
            else
            {
                fejsebzes = 88;
                testsebzes = 25;
                labsebzes = 21;
            }
            tarmeret = 15;
            firerate = 6.75;
            creds = 500;
            mode = "Semi-automatic";
        }
    }
    class Sheriff : Weapons
    {
        public Sheriff()
        {
            if (tavolsag > 0 && tavolsag < 30)
            {
                fejsebzes = 160;
                testsebzes = 55;
                labsebzes = 47;
            }
            else
            {
                fejsebzes = 145;
                testsebzes = 50;
                labsebzes = 43;
            }
            tarmeret = 6;
            firerate = 4;
            creds = 800;
            mode = "Semi-Automatic";
            KepPath = "Sheriff pistol.png";

        }
        public override string ToString()
        {
            return "Sheriff";
        }

    }
}
