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
        //
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
        public char Id { get; } = 'P';
        

        public Polis(int xposition, int yposition, string name, int riktning) : base (xposition, yposition, name, riktning)
        {

          
        }

    }



    internal class Medborgare : Person
    {
        public char Id { get; } = 'C';

        public Medborgare(int xposition, int yposition, string name, int riktning) : base(xposition, yposition, name, riktning)
        {
           

        }

    }


    internal class Tjuv : Person
    {
        public char Id { get; } = 'T';
        public bool Fri { get; set; }

        public Tjuv(int xposition, int yposition, string name, int riktning, bool fri) : base(xposition, yposition, name, riktning)
        {
            
            Fri = fri;

        }

    }
}
