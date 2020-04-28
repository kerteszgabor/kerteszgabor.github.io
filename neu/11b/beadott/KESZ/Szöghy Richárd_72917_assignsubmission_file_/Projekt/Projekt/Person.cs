using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Person
    {
        public string job;
        protected string alignment;
        protected Race race;
        protected string name;
        public string Name { get => name; }
        public string Race { get => race.Name; }
        public Person(string j, Race r, string n)
        {
            race = r;
            alignment = race.Alignment;
            job = j;
            name = n;
        }
    }

    class Character : Person
    {
        Classes kaszt;
        int str;
        int chr;
      public   int wsd;
        public Character(string j, Race r, Classes kaszt, string n) : base(j, r,n)
        {
            this.kaszt = kaszt;
            Random random = new Random();
            str = random.Next(10, 20) + race.StrengthModifier + kaszt.StrengthModifier;
            chr = random.Next(10, 20) + race.CharismaModifier + kaszt.CharismaModifier;
            wsd = random.Next(10, 20) + race.WisdomModifier + kaszt.WisdomModifier;
        }
        public string Kaszt { get => kaszt.Name; }
        public List<string> Spells { get => kaszt.Spells; }
        public void RaceAbility(object target)
        {
            this.race.Ability(target);
        }

        public int StrengthCheck()
        {
            Random r = new Random();
            return r.Next(1,21) + (str - 10) / 4;
        }
        public int CharismaCheck()
        {
            Random r = new Random();
            return r.Next(1,21) + (chr - 10) / 4;
        }
        public int WisdomCheck()
        {
            Random r = new Random();
            return r.Next(1,21) + (wsd - 10) / 4;
        }
    }
}
