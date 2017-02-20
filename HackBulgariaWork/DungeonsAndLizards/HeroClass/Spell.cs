using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroClass
{
    public class Spell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int ManaCost { get; set; }
        public int CastRange { get; set; }

        public Spell(string name, int damage, int manaCost, int castRange)
        {       
            Name = name;
            Damage = damage;
            ManaCost = manaCost;
            CastRange = castRange;
        }
    }
}
