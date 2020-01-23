using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    class Program
    {
        static void Main(string[] args)
        {
            // wyrzucic puste interfejsy i dziedzieczenie z klas
            // potestować
            // dodać więcej przypadków
            // lepsze formatowanie wyswietlania
            Hero Anduin = new Hero("Anduin", 100,50,20,10);
            Item helm = new Item("Hełm Zajebistego Projektu", 11, 0, 10, 10);
            Item rozdzka = new Item("Rozdzka", 0, 100, 20, 0);

            Anduin.Equipment.AddToEquipmentDict("Head", helm);
            Anduin.Equipment.DisplayEquipment();

            Anduin.CalculateStats();
            Anduin.GetStats();

            Anduin.Equipment.AddToEquipmentDict("Hands", rozdzka);
            Anduin.Equipment.DisplayEquipment();
            Anduin.CalculateStats();
            Anduin.GetStats();

            Anduin.Equipment.RemoveFromEquipmentDict("Head");
            Anduin.Equipment.DisplayEquipment();

            Anduin.CalculateStats();
            Anduin.GetStats();



            Console.ReadKey();
        }
    }
}
