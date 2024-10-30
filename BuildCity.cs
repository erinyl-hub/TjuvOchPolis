using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class BuildCity
    {
        public static void Border()
        {
            int x = 102;

            for (int i = 0; i < x; i++)
            {
                Console.Write("x");
            }
        }
        public static void Bana(List<Person> citizens)
        {
            int x = 100;
            int y = 25;

            Console.WriteLine();
            for (int z = 0; z < y; z++)
            {
                Console.Write("x");

                for (int f = 0; f < x; f++)
                {
                    bool inneBana = false;
                    
                    if (inneBana == false)
                    {
                        Console.Write(" ");
                    }                                      
                }
                Console.Write("x");
                Console.WriteLine();
            }
        }
    }
}
