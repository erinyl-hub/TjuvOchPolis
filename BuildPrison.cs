using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class BuildPrison
    {

        //Flyttar taket
        public static void BuildPrisonBorder()
        {
            Console.Write("    ");
            Console.Write("╔");
            for (int i = 0; i < 24; i++)
            {
                
                Console.Write("═");
            }
            Console.Write("╗");
        }

        //Flyttar golvet
        public static void BuildPrisonBottom()
        {
            Console.Write("    ");
            Console.Write("╚");
            for (int i = 0; i < 24; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");           
        }

        public static void BuildPrisonWalls(int z)

        {
            if(z == 5 || z == 7)
            {

                Console.Write("════║");
            }
            else
            {
                
                Console.Write("    ║");
            }


            

            //fluttar den höra väggen

            for (int i = 0; i < 24; i++) 
            {
               Console.Write(" ");
            }
            Console.Write("║");
        }

        public static void FixPrisonWall()
        {

            WriteWall(107, 4);
            WriteWall(107, 20);
        }

        public static void WriteWall(int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("════════════════════════");
            Console.ResetColor();

        }
        
    }
}
