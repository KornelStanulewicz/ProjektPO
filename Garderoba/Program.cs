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
            Hero jackek = new Hero(100,50,20,10,15);
            Item miecz = new Item("Hełm Zajebistego Projektu", 100, 10, 10, 10, 10);
            jackek.Załuż_Item(miecz, jackek.ekwipunek.Głowa);
            Console.WriteLine($"Bohater założył {miecz.nazwa}");
            Console.WriteLine($"Statystyki bohatera: ");
            jackek.GetStats();
            Console.ReadKey();
        }
    }
}
