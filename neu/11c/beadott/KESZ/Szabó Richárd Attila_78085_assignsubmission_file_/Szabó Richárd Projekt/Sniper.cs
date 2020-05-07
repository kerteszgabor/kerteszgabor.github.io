﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szabó_Richárd_Projekt
{
    //Sniper class
    class Marshal : Weapons
    {
        public Marshal()
        {
            fejsebzes = 202;
            testsebzes = 101;
            labsebzes = 85;
            tarmeret = 5;
            firerate = 1.5;
            creds = 1100;
            nev = "Marshal";
        }
        public override string Mode()
        {
            return "Semi-automatic";
        }
        public override string KepPath { get; set; } = "Marshal Sniper.png";
    }
    class Operator : Weapons
    {
        public Operator()
        {
            fejsebzes = 255;
            testsebzes = 150;
            labsebzes = 127;
            tarmeret = 5;
            firerate = 0.75;
            creds = 4500;
            nev = "Operator";
        }
        public override string Mode()
        {
            return "Semi-automatic";
        }
        public override string KepPath { get; set; } = "Operator Sniper.png";
    }
}
