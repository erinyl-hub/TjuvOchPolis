using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class BuildPrison
    {
        public static void BuildPrisonBorder()
        {
            Console.Write("   ");

            for (int i = 0; i < 22; i++)
            {
                
                Console.Write("X");

            }

        }

        public static void BuildPrisonWalls()

        {
            Console.Write("   X");
            for (int i = 0; i < 20; i++) 
            {
               Console.Write(" ");
            }
            Console.Write("X");
        }
    }
}
