using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class GameTopText
    {
        public static bool IsGameRunning { get; private set; } = false; // Spelstatus
        public static bool IsGamePaused { get; private set; } = false;

        public static void GameTextWelcome()
        {
            Console.Clear();
            string welcomeMessage = "══════════ Välkommna till spelet Tjuv & Polis! ══════════";
            
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

        public static void GamePlayerPress(List<Person> citizens, List<string> messages)
        {
            char input = Console.ReadKey(true).KeyChar;

            Console.WriteLine();

            switch (input)
            {
                case 's':

                    IsGameRunning = true;
                    RunGameLoop(citizens, messages);
                    break;

                case 'p':




                    break;

                case 'r':

                    IsGameRunning = false;

                    break;

                default:
                    

                    break;
            }
        }


        // Metod för att köra spel-loopen
        public static void RunGameLoop(List<Person> citizens, List<string> messages)
        {
            while (true)
            {
                

                if (IsGameRunning)
                {
                    if (!IsGamePaused)
                    {
                        // Flytta alla karaktärer
                        Movment.Rörelse(citizens, messages);

                        NewsFeed.WriteMessages(messages);
                    }

                    System.Threading.Thread.Sleep(100); 
                }
                else
                {
                    
                    
                    System.Threading.Thread.Sleep(500); // Pausa mellan meddelanden ?
                }
            }
        }
    }
}