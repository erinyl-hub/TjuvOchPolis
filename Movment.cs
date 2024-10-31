﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Movment
    {
        public static void Rörelse(List<Person> citizens, List<string> messages)
        {

            Meeting.PersonMeeting(citizens, messages);

            foreach (Person person in citizens)
            {

                
                    Console.SetCursorPosition(person.XPosition, person.YPosition);
                    Console.Write(" ");
                
                if (person is Tjuv)
                {
                    if (ThiefInfo.ThiefFree(person)) // Om tjuv inte är fri
                    {


                    }
                    else // Om tjuv är fri
                    {
                        FlyttaPerson(person);
                    }
                }
                else
                { 
                FlyttaPerson(person);
                }




                Console.SetCursorPosition(person.XPosition, person.YPosition);
                AddColor.SkrivUtPersonMedFärg(person);
                Console.ResetColor();
            }
        }


        public static List<int> HämtaTillåtnaRiktningar(int x, int y)
        {
            List<int> tillåtnaRiktningar = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };

            if (x <= 1)
                tillåtnaRiktningar = new List<int> { 3, 5, 6 };

            else if (x >= 100)
                tillåtnaRiktningar = new List<int> { 2, 4, 7 };

            else if (y <= 5)  //ändra
                tillåtnaRiktningar = new List<int> { 1, 5, 7 };

            else if (y >= 29) //ändra
                tillåtnaRiktningar = new List<int> { 0, 4, 6 };

            return tillåtnaRiktningar;
        }


        // NY METOD: Slumpa en ny riktning från de tillåtna
        public static int SlumpaNyRiktning(List<int> tillåtnaRiktningar)
        {
            Random rand = new Random();
            return tillåtnaRiktningar[rand.Next(tillåtnaRiktningar.Count)];
        }


        // NY METOD: Flytta personen baserat på riktningen
        public static void FlyttaPerson(Person person)
        {
            List<int> tillåtnaRiktningar = HämtaTillåtnaRiktningar(person.XPosition, person.YPosition);

            if (tillåtnaRiktningar.Count < 8)
            {
                person.Riktning = SlumpaNyRiktning(tillåtnaRiktningar);
            }

            switch (person.Riktning)
            {
                case 0: if (person.YPosition > 5) person.YPosition--; break;
                case 1: if (person.YPosition < 30) person.YPosition++; break;
                case 2: if (person.XPosition > 1) person.XPosition--; break;
                case 3: if (person.XPosition < 100) person.XPosition++; break;
                case 4: if (person.YPosition > 5 && person.XPosition > 1) { person.YPosition--; person.XPosition--; } break;
                case 5: if (person.YPosition < 30 && person.XPosition < 100) { person.YPosition++; person.XPosition++; } break;
                case 6: if (person.YPosition > 5 && person.XPosition < 100) { person.YPosition--; person.XPosition++; } break;
                case 7: if (person.YPosition < 30 && person.XPosition > 1) { person.YPosition++; person.XPosition--; } break;
            }
        }


    }
}