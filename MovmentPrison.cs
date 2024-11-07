using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class MovmentPrison
    {
        // x 106, 125
        // y 5, 19

        public static void PrisonEnter(Tjuv tjuv)
        {
            tjuv.YPosition = 11;
            tjuv.XPosition = 96;
            
            for (int i = 0; i < 11; i++)
            {

                tjuv.XPosition++;
                Console.SetCursorPosition(tjuv.XPosition, tjuv.YPosition);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("🦹");

                if (i < 3)
                {
                    int polisY = tjuv.YPosition - 1;
                    Console.SetCursorPosition(tjuv.XPosition, polisY);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("🚔");
                    System.Threading.Thread.Sleep(150);
                    Console.SetCursorPosition(tjuv.XPosition, polisY);
                    if (i < 2)
                    {
                        Console.Write(" ");
                    }
                }

                else
                {
                    System.Threading.Thread.Sleep(150);
                }

                if (i == 2)
                {
                    System.Threading.Thread.Sleep(800);
                    OppenDoor((tjuv.XPosition + 1), tjuv.YPosition);
                    

                }

                if(i == 6)  
                {
                    System.Threading.Thread.Sleep(500);
                    CloseDoor((tjuv.XPosition - 2), tjuv.YPosition);
                    System.Threading.Thread.Sleep(500);
                    OppenDoor((tjuv.XPosition + 2), tjuv.YPosition);
                }
               

                if (i == 10)
                {
                    System.Threading.Thread.Sleep(500);
                    CloseDoor((tjuv.XPosition - 1), tjuv.YPosition);
                    System.Threading.Thread.Sleep(150);
                }

                Console.SetCursorPosition(tjuv.XPosition, tjuv.YPosition);
                Console.Write(" ");
            }
            Console.SetCursorPosition((tjuv.XPosition - 7), (tjuv.YPosition - 1));
            Console.Write(" ");

        }
        public static void PrisonExit(Tjuv tjuv)
        {

            tjuv.YPosition = 11;
            tjuv.XPosition = 108;

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(tjuv.XPosition, tjuv.YPosition);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("🦹");

                if (i == 1)
                {
                    System.Threading.Thread.Sleep(800);
                    OppenDoor((tjuv.XPosition - 1), tjuv.YPosition);
                }

                if (i == 5)
                {
                    System.Threading.Thread.Sleep(500);
                    CloseDoor((tjuv.XPosition + 3), tjuv.YPosition);
                    System.Threading.Thread.Sleep(500);
                    OppenDoor((tjuv.XPosition - 2), tjuv.YPosition);
                }

                if (i == 9)
                {
                    System.Threading.Thread.Sleep(500);
                    CloseDoor((tjuv.XPosition + 2), tjuv.YPosition);
                    System.Threading.Thread.Sleep(200);
                }

                Thread.Sleep(150);
                Console.SetCursorPosition(tjuv.XPosition, tjuv.YPosition);
                Console.Write(" ");
                tjuv.XPosition--;
            }
        }



        public static void CloseDoor(int doorX, int doorY)
        {
            Console.SetCursorPosition(doorX, doorY);
            Console.ResetColor();
            Console.Write("║");
        }

        public static void OppenDoor(int doorX, int doorY)
        {
            Console.SetCursorPosition(doorX, doorY);
            Console.ResetColor();
            Console.Write(" ");
        }


    }
}
