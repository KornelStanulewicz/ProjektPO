using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    class Equipment
    {
        public Slot Head;
        public Slot Chest;
        public Slot Shoulders;
        public Slot Hands;
        public Slot Legs;
        public Slot Feet;
        public Slot Finger;

        public Equipment()
        {
            Head = new Slot();
            Chest = new Slot();
            Shoulders = new Slot();
            Hands = new Slot();
            Legs = new Slot();
            Feet = new Slot();
            Finger = new Slot();
        }

        public List<Item> Return_Your_Eq()
        {
            List <Item>list= new List<Item>();
            List<Item> tmp = new List<Item>();
            list.Add(Head.item);
            list.Add(Chest.item);
            list.Add(Shoulders.item);
            list.Add(Hands.item);
            list.Add(Legs.item);
            list.Add(Feet.item);
            list.Add(Finger.item);
            //wywalanie nulli
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]!=null)
                {
                    tmp.Add(list[i]);
                }
            }
            return tmp;
        }
        public override string ToString()
        {
            string result = String.Empty;
            foreach(var e in this.Return_Your_Eq())
            {
                result += e.name + "\n";
            }
            return result == String.Empty ? "PUSTO" : result;
        }
    }
}
