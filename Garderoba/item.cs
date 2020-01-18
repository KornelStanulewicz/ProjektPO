using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    public class Item
    {
       public string nazwa;
       public double wartość;
       public Statystyki statystyki = new Statystyki();
        public Item(string nazwa, double wartość,int armor,int spell,double crit,int attack)
        {
            this.nazwa = nazwa;
            this.wartość = wartość;
            statystyki.Armor = armor;
            statystyki.SpellPower = spell;
            statystyki.CritCanse = crit;
            statystyki.Atack = attack;
        }
    }
}
