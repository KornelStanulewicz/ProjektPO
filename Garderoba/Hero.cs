using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    class Hero
    {
        public Equipment equipment;
        public Stats stats;

        public Hero(int hP, int mP, int strenght, int agility)
        {
            this.equipment = new Equipment();
            this.stats = new Stats(hP,mP,strenght,agility);
        }

        public void CalculateStats()
        {

            stats.Armor = 0;
            stats.Attack = 0;
            stats.SpellPower = 0;
            stats.HitChance = 0;
            foreach (var item in equipment.Return_Your_Eq())
            {
                stats.Armor += item.stats.Armor;
                stats.Attack += item.stats.Attack;
                stats.SpellPower += item.stats.SpellPower;
                stats.HitChance += item.stats.HitChance;
            }
            stats.Attack *= 1 + stats.Strenght / 100;
            stats.SpellPower *= 1 + stats.MP / 100;
            stats.HitChance *= 1 + stats.Agility / 100;
            stats.Armor *= 1 + stats.HP / 100;
        }
        public void PutOn(Item Item,Slot slot)
        {
            if (slot.item==null)
            {
                slot.item = Item;
                Console.WriteLine(Item.ToString());
                this.equipment.Head.item = Item;
                Console.WriteLine(this.equipment.ToString());
                CalculateStats();
            }

        }
        public void RemoveItem(Slot slot)
        {
            slot.item = null;

            CalculateStats();
        }

        public void GetStats()
        {
            Console.WriteLine($"Statystyki bohatera: ");
            Console.WriteLine("Punkty Zdrowia: " + stats.HP + " Magia: " + stats.MP 
                + " Siła: " + stats.Strenght + " Zręczność: " + stats.Agility);
        }
    }
}
