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
            item miecz = new item("Miecz Zajebistego Projektu", 100, 0, 0, 0.06, 2);
            jackek.Załuż_Item(miecz, jackek.ekwipunek.Głowa);
            Console.WriteLine($"Bohater założył {miecz.nazwa}");
            Console.ReadKey();
        }
    }
}
