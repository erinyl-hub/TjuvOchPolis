using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Person
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public string Name { get; set; }
        //public List<>| Inventory { get; set; }
        public int Riktning { get; set; }
        public Person(int xposition, int yposition, string name, int riktning)
        {
            XPosition = xposition;
            YPosition = yposition;
            Name = name;
            Riktning = riktning;

        }
    }

    internal class Polis : Person
    {       
        public Inventory SeizedGoods { get; set; }

        public Polis(Inventory seizedGoods, int xposition, int yposition, string name, int riktning) : base (xposition, yposition, name, riktning)
        {
            SeizedGoods = seizedGoods;        
        }

    }

    internal class Medborgare : Person
    {
        public Inventory Belongings { get; set; }

        public Medborgare(Inventory belongings, int xposition, int yposition, string name, int riktning) : base(xposition, yposition, name, riktning)
        {          
            Belongings = belongings;
        }

    }

    internal class Tjuv : Person
    {
        public bool Fri { get; set; }
        public Inventory StolenGoods { get; set; }

        public Tjuv(Inventory stolenGoods, int xposition, int yposition, string name, int riktning, bool fri) : base(xposition, yposition, name, riktning)
        {
            StolenGoods= stolenGoods;
            Fri = fri;
        }

    }
}
