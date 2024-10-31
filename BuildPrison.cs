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
            Console.Write("╔");
            for (int i = 0; i < 21; i++)
            {
                
                Console.Write("=");

            }
            Console.Write("╗");

        }

        public static void BuildPrisonBottom()
        {
            Console.Write("   ");
            Console.Write("╚");
            for (int i = 0; i < 21; i++)
            {

                Console.Write("=");

            }
            Console.Write("╝");

        }

        public static void BuildPrisonWalls()

        {
            Console.Write("   ║");
            for (int i = 0; i < 21; i++) 
            {
               Console.Write(" ");
            }
            Console.Write("║");
        }
    }
}
