﻿using System;
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

            int x = 100;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("╔");
            for (int i = 0; i < x; i++)
            {
                Console.Write("═"); 
            }
            Console.Write("╗");
        }

        public static void BottomBorder()
        {

            int x = 100;

            Console.Write("╚");
            for (int i = 0; i < x; i++)
            {
                Console.Write("═"); 
            }
            Console.WriteLine("╝"); 
        }

        public static void Bana()
        {
            int x = 100;
            int y = 25;

            BuildPrison.BuildPrisonBorder();
            Console.WriteLine();

            

            for (int z = 0; z < y; z++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("║"); //Vänster vägg av banan

                for (int f = 0; f < x; f++)
                {
                    Console.Write(" ");

                }

                Console.Write("║"); //Höger vägg av banan

                if (z < 15 )
                {
                    BuildPrison.BuildPrisonWalls(z);

                }

                if (z == 15 )

                {
                    BuildPrison.BuildPrisonBottom();
                }
               Console.WriteLine();              
            }      
        }

        public static void FixCityWall()
        {
            WriteWall(2, 4);
            WriteWall(2, 30);

            //WriteWall(107, 4, 24);
            //WriteWall(107, 20, 24);
        }

        public static void WriteWall(int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.ForegroundColor= ConsoleColor.Cyan;
                Console.Write("═══════════════════════════════════════════════════════════════════════════════════════════════════");
            Console.ResetColor();     
        }


    }
}
