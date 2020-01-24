using Garderoba.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba.Classes
{
    public class HeroStats : AbstractStats
    {
        public int HP { get; set; }
        public int MP { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public EquipmentStats EquipmentStats { get; set; }
        public HeroStats(int hp, int mp, int strength, int agility)
        {
            this.HP = hp;
            this.MP = mp;
            this.Strength = strength;
            this.Agility = agility;
            this.EquipmentStats = new EquipmentStats();
        }
        public override void DisplayStats()
        {
            Console.WriteLine($"Punkty Zdrowia: {this.HP}, Magia: {this.MP}, " +
                $"Siła: {this.Strength}, Zręczność: {this.Agility}");
        }

        
    }
}
