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
        public int tavolsag;
        protected string nev;

        //Tulajdonságok    
        public virtual int Fejsebzes
        {
            get => fejsebzes;
            set
            {
                fejsebzes = value;
            }
        }
        public virtual int Testsebzes
        {
            get => testsebzes;
            set
            {
                testsebzes = value;
            }
        }
        public virtual int Labsebzes
        {
            get => labsebzes;
            set
            {
                labsebzes = value;
            }
        }
        public int Tarmeret
        {
            get => tarmeret;
        }
        public double Firerate
        {
            get => firerate;
        }
        public int Creds
        {
            get => creds;
        }
        public int Tavolsag
        {
            get => tavolsag;
            set
            {
                tavolsag = value;
            }
        }
        public abstract string KepPath
        {
            get;
            set;
        }
        //Metódusok
        public abstract string Mode(); //Automata-e a fegyver.

        public override string ToString()
        {
            return nev;
        }
    }
}
