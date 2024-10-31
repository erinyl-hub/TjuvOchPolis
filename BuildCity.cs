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
                Console.Write("x"); //Taket och golvet av banan
            }

            

        }


        public static void Bana()
        {
            int x = 100;
            int y = 25;

            BuildPrison.BuildPrisonBorder();

            Console.WriteLine();

            for (int z = 0; z < y; z++)
            {
                Console.Write("x"); //Vänster vägg av banan

                for (int f = 0; f < x; f++)
                {
                    Console.Write(" ");

                }

                Console.Write("x"); //Höger vägg av banan

                if (z < 15 )
                {
                    BuildPrison.BuildPrisonWalls();

                }

                if (z == 15 )

                {
                    BuildPrison.BuildPrisonBorder();
                }



                    
                
                
                Console.WriteLine();
               
            }
            
        }
    }
}
