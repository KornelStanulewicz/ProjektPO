using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    public class Item
    {
       public string name;
       public Stats stats = new Stats();
        public Item(string name, int armor, int spell, int hit, int attack)
        {
            this.name = name;
            stats.Armor = armor;
            stats.SpellPower = spell;
            stats.HitChance = hit;
            stats.Attack = attack;
        }
        public override string ToString()
        {
            return $"{this.name}| {this.stats.Armor.ToString()}";
        }

    }
}
