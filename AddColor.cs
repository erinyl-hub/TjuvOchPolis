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

        public static string PersonMarkering(Person person)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            if (person is Polis)
            {
                return "👮"; // Emoji för polis
            }
            else if (person is Tjuv)
            {
                return "🦹"; // Emoji för tjuv
            }
            else if (person is Medborgare)
            {
                return "👤"; // Emoji för medborgare
            }

            return " "; // Om inget av ovanstående matchar
        }
    }
}

