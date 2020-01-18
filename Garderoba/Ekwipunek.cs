using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garderoba
{
    class Ekwipunek
    {
        public Slot Głowa;
        public Slot Tłów;
        public Slot Ramiona;
        public Slot Ręce;
        public Slot Nogi;
        public Slot Stopy;
        public Slot Specjaly;

        public Ekwipunek()
        {
            Głowa = new Slot();
            Tłów = new Slot();
            Ramiona = new Slot();
            Ręce = new Slot();
            Nogi = new Slot();
            Stopy = new Slot();
            Specjaly = new Slot();
        }

        public List<item> Zwróć_Założony_Ekwipunek()
        {
            List <item>lista= new List<item>();
            List<item> tmp = new List<item>();
            lista.Add(Głowa.item);
            lista.Add(Tłów.item);
            lista.Add(Ramiona.item);
            lista.Add(Ręce.item);
            lista.Add(Nogi.item);
            lista.Add(Stopy.item);
            lista.Add(Specjaly.item);
            //wywalanie nulli
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i]!=null)
                {
                    tmp.Add(lista[i]);
                }
            }
            return tmp;
        }
    }
}
