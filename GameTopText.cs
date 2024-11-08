using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class GameTopText
    {
        public static bool IsGameRunning { get; set; } = false; 
        public static bool IsGamePaused { get; set; } = false;

        public static void GameTextWelcome()
        {
            Console.Clear();
            
            string welcomeMessage = "══════════ Välkommna till spelet Tjuv & Polis! ══════════";

            int consoleWidth = Console.WindowWidth; // Hämta konsolens bredd

            Console.ForegroundColor = ConsoleColor.White;

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

        public static void GamePlayerPress(List<Person> citizens, List<string> messages, int[] status)
        {
            char input = Console.ReadKey(true).KeyChar;

            Console.WriteLine();

            switch (input)
            {
                case 's':

                    if (!IsGameRunning) 
                    {
                        
                        IsGameRunning = true;
                        IsGamePaused = false;
                        Thread gameThread = new Thread(() => RunGameLoop(citizens, messages, status));
                        gameThread.Start();
                    }

                    else if (IsGamePaused) 
                    {
                        // Återuppta spelet
                        IsGamePaused = false;
                        
                    }
                    break;

                case 'p':

                    if (IsGameRunning) 
                    {

                        IsGamePaused = !IsGamePaused;
                        
                    }
                    break;

                case 'r':

                    GenerateGame(citizens, messages, status); // Anropa den nya återställningsmetoden
                    break;

                default:
                    break;
            }
        }


       
        public static void RunGameLoop(List<Person> citizens, List<string> messages, int[] status)
        {
            while (IsGameRunning)
            {
                if (!IsGamePaused)
                {                 
                    Movment.Rörelse(citizens, messages, status);

                    NewsFeed.WriteMessages(messages);
                    NewsFeed.PrintStatus(status);
                }
                Thread.Sleep(150); 
            }
        }

        // Metod för att återställa spelet vid omstart
        public static void GenerateGame(List<Person> citizens, List<string> messages, int[] status)
        {
            // Stoppa spelet
            IsGameRunning = false;
            IsGamePaused = false;

            // Rensa listor och status
            citizens.Clear();
            messages.Clear();
            Array.Clear(status, 0, status.Length);

            // Återskapa medborgare och tjuvar för en ny spelomgång
            CreateCitizens.AddCitizens(citizens);

            // Rensa konsolen och visa välkomsttext och kontroller
            Console.Clear();
            GameTextWelcome();
            GameTextPlayers();

            // Rita om gränser och spelplan
            BuildCity.Border();
            BuildCity.Bana();
            BuildCity.BottomBorder();

            // Rita om nyhetsfönstret
            
            NewsFeed.NewsFeedMap();
            NewsFeed.NewsFeedBorder();
            NewsFeed.NewsFeedBottom();
            NewsFeed.StatusText();
        }
    }
}
