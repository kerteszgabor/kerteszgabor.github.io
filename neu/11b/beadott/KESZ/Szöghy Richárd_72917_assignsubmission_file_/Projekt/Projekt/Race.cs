using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{

    public abstract class Race
    {
       protected string name;
        protected int maxage;
    
        protected string alignment;
        protected int str;
        protected int wsd;
        protected int chr;
        public int CharismaModifier { get => chr; }
        public int WisdomModifier { get => wsd; }
        public int StrengthModifier { get => str;  }
        public string Name { get => name; }
        public string Alignment { get => alignment; }
        public Race(string n,  int max,  string a)
        {
            name = n;
            
            maxage = max;
      
            alignment = a;
        }

        public abstract void Ability(object target);
    }

    public class Human : Race
    {
        public Human() : base ("human",110,"True Neutral")
        {
            chr = -1;
            wsd = 1;
            str = 1;
            
        }

        public override void Ability(object target)
        {
            Console.WriteLine("Az emberek bénák, nincs különleges képességük");

        }
    }
    public class Mermaid : Race
    {
        public Mermaid() : base("mermaid", 110, "Chaotic Good")
        {
            chr = +5;
            wsd = 0;
            str = -1;

        }

        public override void Ability(object target)
        {
            try
            {
                Console.WriteLine("A célpont bölcsességét (wsd) csökkentette eggyel!");
                ((Character)target).wsd -= 1;
            }
            catch (FormatException) { Console.WriteLine("Hiba, nem megfelelő célpont! Characterre kell irányítani"); }
        }
    }
}
