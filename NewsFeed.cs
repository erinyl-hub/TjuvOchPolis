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
            int yPosition = 33;
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


        public static void PrintStatus(int[] status)
        {
            int yPosition = 21;
            int xPosition = 106;

            Console.SetCursorPosition(xPosition, yPosition); 
            Console.Write("Status:");
            yPosition++;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write($"Fria tjuvar: {status[0]}");
            yPosition++;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write($"Tjuvar i fängelse: {status[1]}");
            yPosition++;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write($"Rånade medborgare: {status[2]}");
            yPosition++;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write($"Munkfika!: {status[3]}");
            yPosition++;

        }





        public static void NewsFeedBorder()
            {
                int x = 70;
                int StartOffset = 14;
                int yPosition = 31;

                Console.SetCursorPosition(44, yPosition);
                Console.WriteLine("NewsFeed");



                Console.Write(new string(' ', StartOffset));
                Console.Write("╔");
                for (int i = 0; i < x; i++)
                {

                    Console.Write("=");

                }
                Console.Write("╗");




            }




            public static void NewsFeedMap()
            {
                int x = 70;
                int y = 7;

                Console.WriteLine();
                for (int z = 0; z < y; z++)
                {
                    Console.Write("              ║");

                    for (int f = 0; f < x; f++)
                    {
                        bool inneBana = false;

                        if (inneBana == false)
                        {
                            Console.Write(" ");

                        }
                    }
                    Console.Write("║");
                    Console.WriteLine();

                }
            }

            public static void NewsFeedBottom()
            {
                int x = 70;
                int Yposition = 39;
                int StartPosition = 0;


                Console.SetCursorPosition(14, Yposition);

                Console.Write(new string(' ', StartPosition));
                Console.Write("╚");
                for (int i = 0; i < x; i++)
                {
                    Console.Write("=");

                }
                Console.Write("╝");
            }




        


    }
}

