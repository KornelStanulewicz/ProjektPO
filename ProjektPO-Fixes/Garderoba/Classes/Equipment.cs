using Garderoba.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    public class Equipment : IEquipment
    {
        public Dictionary<string, Item> Items { get; set; }

        public Equipment()
        {
            this.Items = new Dictionary<string, Item>();
            this.InitizalizeDictionary();
        }

        private void InitizalizeDictionary()
        {
            // ewentualnie zamiana kluczy na male litery -> head itd
            this.Items.Add("Head", null);
            this.Items.Add("Chest", null);
            this.Items.Add("Hands", null);
            this.Items.Add("Legs", null);
            this.Items.Add("Feet", null);
            this.Items.Add("Finger", null);
        }

        public void AddToEquipmentDict(string key, Item item)
        {
            this.Items[key] = item;
        }

        public void RemoveFromEquipmentDict(string key)
        {
            // key = key.toLower()
            this.Items[key] = null;
        }
        
        public void DisplayEquipment()
        {
            Console.WriteLine("===== EQUIPMENT =====");
            foreach (var item in this.Items)
            {
                Console.WriteLine(item.Key);

                if (item.Value != null)
                    Console.WriteLine(item.Value);
                
                else
                    Console.WriteLine("Brak przedmiotu.");
            }
        }

    }
}
