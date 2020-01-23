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
            Hero Anduin = new Hero(100,50,20,10);
            //Item chelm = new Item("Hełm Zajebistego Projektu", 10, 10, 10, 10);
            Item hands = new Item("Rękawice Zniszczenia", 100, 100, 100, 100);
            Anduin.PutOn(hands, Anduin.equipment.Hands);
            //jackek.PutOn(chelm, jackek.equipment.Head);
            Console.WriteLine(Anduin.equipment.ToString());
            //Console.WriteLine($"Bohater założył {chelm.nazwa}");
            Anduin.CalculateStats();
            Anduin.GetStats();

            Console.ReadKey();
        }
    }
}
