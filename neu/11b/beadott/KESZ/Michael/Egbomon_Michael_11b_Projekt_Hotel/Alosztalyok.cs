using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egbomon_Michael_11b_Projekt_Hotel
{
    //Standard típusú szoba osztály
    class Standard : Szoba
    {
        public Standard(double terulet, bool etkezes) : base(terulet, etkezes)
        {
            this.terulet = terulet;
            etkezes =false;
        }

        public override string Tipus()
        {
            return "Ez egy standard típusú szoba. Ez a szolgáltatás nem tartalmaz napi étkezést!";
        }

        public override double Meret()
        {
            return terulet * 2;
        }

    }

    //VIP típusú szoba osztály
    class VIP : Szoba
    {
        public VIP(double terulet, bool etkezes):base(terulet, etkezes)
        {
            this.terulet = terulet;
            etkezes = true;
        }

        public override string Tipus()
        {
            return "Ez egy VIP (superior) típusú szoba. Ez a szolgáltatás tartalmaz napi étkezést!";
        }

        public override double Meret()
        {
            return terulet * 3;
        }

    }

    //Business típusú szoba osztály
    class Business : Szoba
    {
        public Business(double terulet, bool etkezes):base(terulet, etkezes)
        {
            this.terulet = terulet;
            etkezes = true;
        }

        public override string Tipus()
        {
            return "Ez egy business típusú szoba. Ez a szolgáltatás tartalmaz napi étkezést!";
        }

        public override double Meret()
        {
            return terulet * 4;
        }
    }
}
