using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    public class Stats
    {
        public int HP;
        public int MP;
        public int Strenght;
        public int Agility;

        public int Attack;
        public int SpellPower;
        public int HitChance;
        public int Armor;

        public Stats(int hP, int mP, int strenght, int agility)
        {
            HP = hP;
            MP = mP;
            Strenght = strenght;
            Agility = agility;
        }
        public Stats()
        {

        }
    }
}
