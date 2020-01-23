using Garderoba.Classes;
using Garderoba.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    public class Item : IItem
    {
       public string Name { get; set; }
       public EquipmentStats Stats { get; set; }
        public Item(string name, int armor, int spell, int hit, int attack)
        {
            this.Name = name;
            this.Stats = new EquipmentStats(attack, spell, hit, armor);
        }
        public override string ToString()
        {
            return $"{this.Name} | Pancerz: {this.Stats.Armor.ToString()}, Spellpower: {this.Stats.SpellPower.ToString()}, Hitchance: {this.Stats.HitChance.ToString()}, Attack: {this.Stats.Attack.ToString()}";
        }

    }
}
