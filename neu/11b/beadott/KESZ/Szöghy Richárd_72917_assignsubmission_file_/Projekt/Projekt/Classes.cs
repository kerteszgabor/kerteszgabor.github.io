using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public abstract class Classes
    {
        string name;
        int chr;
        int str;
        int wsd;
        List<string> spells;

        public List<string> Spells { get => spells; }
        public int CharismaModifier { get => chr; }
        public int WisdomModifier { get => wsd; }
        public int StrengthModifier { get => str; }
        public string Name { get => name; }

        public Classes(string n, int c, int s, int w, List<string> spells)
        {
            name = n;
            chr = c;
            str = s;
            wsd = w;
            this.spells = spells;
        }
    }

    public class Mage : Classes
    {
        static string[] magespells = {"Fireball","Ray of frost","Mirror image" };
        
        public Mage() : base("mage",1, -1, 2, new List<string>(magespells))
        {

        }
    }
    public class Thief : Classes
    {
        static string[] thiefspells = {"Cloud of Daggers","Invisiblity" };
        
        public Thief() : base("thief",4, 2, 0, new List<string>(thiefspells))
        {

        }
    }
}
