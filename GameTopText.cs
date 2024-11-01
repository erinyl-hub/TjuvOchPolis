using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class GameTopText
    {

        public static void GameTextWelcome()
        {
            Console.Clear();


            string welcomeMessage = "Välkommna till spelet Tjuv & Polis!";
            int consoleWidth = Console.WindowWidth; // Hämta konsolens bredd


            Console.ForegroundColor = ConsoleColor.Cyan;

            // Centrera och skriv ut välkomstmeddelandet
            Console.WriteLine(welcomeMessage.PadLeft((consoleWidth + welcomeMessage.Length) / 2));

            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();

        }



        public static void GameTextPlayers()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[S] Start ");
            Console.Write("    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[P] Paus ");
            Console.Write("    ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[R] Restart ");

            Console.ResetColor();
            Console.WriteLine();
        }


        public static void GamePlayerPress()
        {
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (input)
            {

                case 'S':


                    break;


                case 'P':


                    break;


                case 'R':


                    break;


                default:

                    Console.WriteLine("Ogiltigt val, försök igen.");

                    break;

            }



        }
    }



}
