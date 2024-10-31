using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class NewsFeed
    {
        public static void AddMessages(List<string> messages, Tjuv tjuv, Medborgare medborgare, string goods)
        {
            string message = $"{tjuv.Name} tog en {goods} ifrån {medborgare.Name}";
            messages.Add(message);



        }
        public static void PoliceMsg(List<string> messages, Polis polis1, Polis polis2)
        {
            string policeMsg = $"Polis {polis1.Name} hälsar på Polis {polis2.Name}.";
            messages.Add(policeMsg);
        }

        public static void WriteMessages(List<string> messages)
        {


            int startIndex = Math.Max(messages.Count - 5, 0);
            int yPosition = 27;
            int messageWidth = 60;

            
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(23, yPosition + i);
                Console.Write(new string(' ', messageWidth));
            }

            
            for (int i = messages.Count - 1; i >= startIndex; i--)
            {
                Console.SetCursorPosition(23, yPosition);
                Console.WriteLine($"{i} - {messages[i]}");
                yPosition++;


            }
        }
        public static void NewsFeedBorder()
        {
            int x = 72;
            int StartOffset = 14;

            Console.Write(new string(' ', StartOffset));
            for (int i = 0; i < x; i++)
            {

                Console.Write("x");
            }


        }

        public static void NewsFeedMap()
        {
            int x = 70;
            int y = 5;

            Console.WriteLine();
            for (int z = 0; z < y; z++)
            {
                Console.Write("              x");

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
