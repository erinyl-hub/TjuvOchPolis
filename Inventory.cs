using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Inventory
    {
        public int Key { get; set; }
        public int Mobil { get; set; }
        public int Money { get; set; }
        public int Watch { get; set; }

        public Inventory(int key, int mobil, int money, int watch)
        {
            Key = key;
            Mobil = mobil;
            Money = money;
            Watch = watch;          
        }
        


    }
}
