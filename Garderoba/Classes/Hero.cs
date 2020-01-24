using Garderoba.Classes;
using Garderoba.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    public class Hero : IHero
    {
        public string Name { get; set; }
        public Equipment Equipment { get; set; }
        public HeroStats HeroStats { get; set; }
        public EquipmentStats EquipmentStats { get; set; }

        public Hero(string name, int hp, int mp, int strength, int agility)
        {
            this.Name = name;
            this.HeroStats = new HeroStats(hp, mp, strength, agility);
            this.Equipment = new Equipment();
        }

        public void CalculateStats()
        {

            foreach (var item in this.Equipment.Items)
            {
                if (item.Value != null)
                {
                    HeroStats.EquipmentStats.Armor += item.Value.Stats.Armor;
                    HeroStats.EquipmentStats.Attack += item.Value.Stats.Attack;
                    HeroStats.EquipmentStats.SpellPower += item.Value.Stats.SpellPower;
                    HeroStats.EquipmentStats.HitChance += item.Value.Stats.HitChance;
                }
            }
        }

        public void GetStats()
        {
            Console.WriteLine("Statystyki bohatera: ");
            HeroStats.DisplayStats();
            HeroStats.EquipmentStats.DisplayStats();
            Console.WriteLine("\n");
        }
    }
}
