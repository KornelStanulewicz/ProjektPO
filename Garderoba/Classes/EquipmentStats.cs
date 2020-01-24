using Garderoba.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba.Classes
{
    public class EquipmentStats : AbstractStats
    {
        public int Attack { get; set; }
        public int SpellPower { get; set; }
        public int HitChance { get; set; }
        public int Armor { get; set; }
        public EquipmentStats(int attack, int spellpower, int hitchance, int armor)
        {
            this.Attack = attack;
            this.SpellPower = spellpower;
            this.HitChance = hitchance;
            this.Armor = armor;
        }

        public EquipmentStats() 
        {
            this.Attack = 0;
            this.SpellPower = 0;
            this.HitChance = 0;
            this.Armor = 0;
        }

        public override void DisplayStats()
        {
            Console.WriteLine($"Pancerz: {this.Armor}, Siła czarów: {this.SpellPower}, " +
                $"Szansa na uderzenie: {this.HitChance}, Atak: {this.Attack}");
        }
    }
}
