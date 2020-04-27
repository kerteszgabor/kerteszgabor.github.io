using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szabó_Richárd_Projekt
{
    abstract class Weapons
    {
        //Adattagok
        protected int fejsebzes;
        protected int testsebzes;
        protected int labsebzes;
        protected int tarmeret;
        protected double firerate; //Milyen gyorsan lő (rounds/secben)
        protected int creds; //Mennyi játékbeli pénzbe kerül
        protected double tavolsag;
        protected string mode; //Automatikus a fegyver vagy nem
        public string KepPath { get; set; }

        //Tulajdonságok    
        public int Fejsebzes
        {
            get
            {
                return fejsebzes;
            }
        }
        public int Testsebzes
        {
            get
            {
                return testsebzes;
            }
        }
        public int Labsebzes
        {
            get
            {
                return labsebzes;
            }
        }
        public int Tarmeret
        {
            get
            {
                return tarmeret;
            }
        }
        public double Firerate
        {
            get
            {
                return firerate;
            }
        }
        public int Creds
        {
            get
            {
                return creds;
            }
        }

        public string Mode
        {
            get
            {
                return mode;
            }
        }
    }
}
