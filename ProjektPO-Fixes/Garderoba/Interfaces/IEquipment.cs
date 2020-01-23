using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba.Interfaces
{
    interface IEquipment
    {
        void AddToEquipmentDict(string key, Item item);
        void DisplayEquipment();
    }
}
