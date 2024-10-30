using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class AddColor
    {
        public static void SkrivUtPersonMedFärg(Person person)
        {
            if (person is Polis)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (person is Tjuv)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (person is Medborgare)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write(PersonMarkering(person));
        }

        public static char PersonMarkering(Person person)
        {
            if (person is Polis) return 'P';
            else if (person is Tjuv) return 'T';
            else if (person is Medborgare) return 'C';

            return ' ';
        }
    }
}

