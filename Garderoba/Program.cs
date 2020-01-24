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
            Console.WriteLine("==== Scenariusz pierwszy ====\n");

            Hero Anduin = new Hero("Anduin", 100, 350, 20, 10);
            Item helm = new Item("Hełm Świetnego Projektu", 5, 5, 5, 5);
            Item chest = new Item("Szata Kapłana", 30, 100, 90, 10);
            Item rekawice = new Item("Rękawice Czarów", 20, 110, 10, 10);
            Item spodnie = new Item("Spodnie Magii", 15, 70, 20, 0);
            Item buty = new Item("Buty Maga", 20, 200, 50, 0);
            Item pierscien = new Item("Jedyny Pierścień", 50, 50, 50, 50);

            Console.WriteLine($"==== Statystyki bohatera przed nałożeniem ubioru ====\n");
            Anduin.Equipment.DisplayEquipment();
            Anduin.CalculateStats();
            Anduin.GetStats();

            Anduin.Equipment.AddToEquipmentDict("Head", helm);
            Anduin.Equipment.AddToEquipmentDict("Chest", chest);
            Anduin.Equipment.AddToEquipmentDict("Hands", rekawice);
            Anduin.Equipment.AddToEquipmentDict("Legs", spodnie);
            Anduin.Equipment.AddToEquipmentDict("Feet", buty);
            Anduin.Equipment.AddToEquipmentDict("Finger", pierscien);

            Console.WriteLine($"==== Statystyki bohatera po nałożeniu ubioru ====\n");
            Anduin.Equipment.DisplayEquipment();
            Anduin.CalculateStats();
            Anduin.GetStats();

            Console.WriteLine("==== Scenariusz drugi ====\n");
            
            Hero Arthas = new Hero("Arthas", 200, 50, 100, 50);
            Item helm2 = new Item("Hełm Władcy", 50, 0, 10, 30);
            Item chest2 = new Item("Mroczna Zbroja", 100, 10, 50, 60);
            Item rekawice2 = new Item("Rękawice Lodu", 30, 5, 70, 40);
            Item spodnie2 = new Item("Spodnie Cthulu", 70, 0, 20, 30);
            Item buty2 = new Item("Buty Rycerza", 40, 0, 40, 40);
            Item pierscien2 = new Item("Pierścionek Zaręczynowy", 1, 1, 1, 1);

            Console.WriteLine($"==== Statystyki bohatera przed nałożeniem ubioru ====\n");
            Arthas.Equipment.DisplayEquipment();
            Arthas.CalculateStats();
            Arthas.GetStats();

            Arthas.Equipment.AddToEquipmentDict("Head", helm2);
            Arthas.Equipment.AddToEquipmentDict("Chest", chest2);
            Arthas.Equipment.AddToEquipmentDict("Hands", rekawice2);
            Arthas.Equipment.AddToEquipmentDict("Legs", spodnie2);
            Arthas.Equipment.AddToEquipmentDict("Feet", buty2);
            Arthas.Equipment.AddToEquipmentDict("Finger", pierscien2);

            Arthas.Equipment.RemoveFromEquipmentDict("Finger");

            Console.WriteLine($"==== Statystyki bohatera po nałożeniu ubioru ====\n");
            Arthas.Equipment.DisplayEquipment();
            Arthas.CalculateStats();
            Arthas.GetStats();



            Console.ReadKey();
        }
    }
}
