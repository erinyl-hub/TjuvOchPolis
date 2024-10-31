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
            tjuv.YPosition = 1;
            tjuv.XPosition = 116;
            
            for (int i = 0; i < 4; i++)
            {
                int polisX = tjuv.XPosition - 1;              
                tjuv.YPosition ++;            
                Console.SetCursorPosition(tjuv.XPosition, tjuv.YPosition);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("T");
                if(i < 2)
                {
                    Console.SetCursorPosition(polisX, tjuv.YPosition);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("P");
                    

                }
    
                System.Threading.Thread.Sleep(250);
                Console.SetCursorPosition(polisX, tjuv.YPosition);
                Console.Write(" ");
                Console.SetCursorPosition(tjuv.XPosition, tjuv.YPosition);
                Console.Write(" ");
            }
        }


       

        public static List<int> HämtaTillåtnaRiktningar(int x, int y)
        {
            List<int> tillåtnaRiktningar = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };

            if (x <= 106  )
                tillåtnaRiktningar = new List<int> { 3, 5, 6 };

            else if (x >= 126)
                tillåtnaRiktningar = new List<int> { 2, 4, 7 };

            else if (y <= 5)  //ändra
                tillåtnaRiktningar = new List<int> { 1, 5, 7 };

            else if (y >= 19) //ändra
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
        public static void FlyttaTjuv(Person person)
        {
            List<int> tillåtnaRiktningar = HämtaTillåtnaRiktningar(person.XPosition, person.YPosition);

            if (tillåtnaRiktningar.Count < 8)
            {
                person.Riktning = SlumpaNyRiktning(tillåtnaRiktningar);
            }

            switch (person.Riktning)
            {
                case 0: if (person.YPosition > 5) person.YPosition--; break;
                case 1: if (person.YPosition < 20) person.YPosition++; break;
                case 2: if (person.XPosition > 106) person.XPosition--; break;
                case 3: if (person.XPosition < 126) person.XPosition++; break;


                case 4: if (person.YPosition > 5 && person.XPosition > 106) { person.YPosition--; person.XPosition--; } break;
                case 5: if (person.YPosition < 20 && person.XPosition < 127) { person.YPosition++; person.XPosition++; } break;
                case 6: if (person.YPosition > 5 && person.XPosition < 127) { person.YPosition--; person.XPosition++; } break;
                case 7: if (person.YPosition < 20 && person.XPosition > 106) { person.YPosition++; person.XPosition--; } break;
            }
        }




    }
}
