using Garderoba.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    public class Slot : ISlot
    {
        public Item Item { get; set; }

        public Slot()
        {
        }
    }
}
