﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    class Hero
    {
        public Ekwipunek ekwipunek;
        public Statystyki statystyki;

        public Hero(int hP, int mP, int siła, int zręcznoś, int inteligencja)
        {
            this.ekwipunek = new Ekwipunek();
            this.statystyki = new Statystyki(hP,mP,siła,zręcznoś,inteligencja);
        }

        public void ObliczStatystyki()
        {

            statystyki.Armor = 0;
            statystyki.Atack = 0;
            statystyki.SpellPower = 0;
            statystyki.CritCanse = 0;
            foreach (var item in ekwipunek.Zwróć_Założony_Ekwipunek())
            {
                statystyki.Armor += item.statystyki.Armor;
                statystyki.Atack += item.statystyki.Atack;
                statystyki.SpellPower += item.statystyki.SpellPower;
                statystyki.CritCanse += item.statystyki.CritCanse;
            }
            statystyki.Atack *= 1 + statystyki.Siła / 100;
            statystyki.SpellPower *= 1 + statystyki.Inteligencja / 100;
            statystyki.CritCanse *= 1 + statystyki.Zręcznoś / 100;
        }
        public void Załuż_Item(item Item,Slot slot)
        {
            if (slot.item==null)
            {
                slot.item = Item;
                ObliczStatystyki();
            }

        }
        public void Zdejmij_Item(Slot slot)
        {
            slot.item = null;

            ObliczStatystyki();
        }
    }
}