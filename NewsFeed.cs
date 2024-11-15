﻿using System;
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
            string message = $"{tjuv.Name} stal en {goods} ifrån {medborgare.Name}";
            messages.Add(message);
        }

        public static void PoliceMsg(List<string> messages, Polis polis1, Polis polis2)
        {
            string policeMsg = $"Polis {polis1.Name} tog en munkfika {polis2.Name}.";
            messages.Add(policeMsg);
        }

        public static void PoliceCatchThiefMsg(List<string> messages, Polis polis, Tjuv tjuv)
        {
            string catchMsg = $"Polis {polis.Name} arresterade tjuven {tjuv.Name}";
            messages.Add(catchMsg);
        }
        
        public static void PoorMsg(List<string> messages, Medborgare medborgare)
        {
            string catchMsg = $"{medborgare.Name} har inget kvar, och är nu fattig.";
            messages.Add(catchMsg);
        }


        public static void WriteMessages(List<string> messages)
        {
            int startIndex = Math.Max(messages.Count - 5, 0);
            int yPosition = 33;
            int messageWidth = 62;

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(21, yPosition + i);
                Console.Write(new string(' ', messageWidth));
            }

            for (int i = messages.Count - 1; i >= startIndex; i--)
            {
                Console.SetCursorPosition(21, yPosition);
                Console.WriteLine($"{i} - {messages[i]}");
                yPosition++;
            }
        }


        //Gjorde en ny metod för texten då jag inte visste hur den annars skulle skrivas ut innan [S] start.
        public static void StatusText()
        {
            int yPosition = 21;
            int xPosition = 112;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.ForegroundColor = ConsoleColor.White; Console.Write("═══ Status ═══"); Console.ResetColor();

        }

        public static void PrintStatus(int[] status)
        {
            int yPosition = 21;
            int xPosition = 109;

            
            
       
            yPosition++;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write($"Fria tjuvar: {status[0]} ");
            yPosition++;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write($"Tjuvar i fängelse: {status[1]} ");
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

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(44, yPosition);
            Console.WriteLine("═══ NewsFeed ═══");
            Console.ResetColor();

            Console.Write(new string(' ', StartOffset));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("╔");
            for (int i = 0; i < x; i++)
            {
                Console.Write("═");
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
                Console.Write("═");
            }
            Console.Write("╝");
        }
    }
}

