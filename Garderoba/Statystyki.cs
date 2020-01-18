using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    public class Statystyki
    {
        public int HP;
        public int MP;
        public int Siła;
        public int Zręcznoś;
        public int Inteligencja;

        public int Atack;
        public int SpellPower;
        public double CritCanse;
        public int Armor;

        public Statystyki(int hP, int mP, int siła, int zręcznoś, int inteligencja)
        {
            HP = hP;
            MP = mP;
            Siła = siła;
            Zręcznoś = zręcznoś;
            Inteligencja = inteligencja;
        }
        public Statystyki()
        {

        }
    }
}
