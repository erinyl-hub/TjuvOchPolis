using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Movment
    {
        public static void Rörelse(List<Person> citizens, List<string> messages, int[] status)
        {
            Meeting.PersonMeeting(citizens, messages, status);

            status[0] = 0;
            status[1] = 0;
            foreach (Person person in citizens)
            {
                Console.SetCursorPosition(person.XPosition, person.YPosition);
                Console.Write(" ");

                if (person is Tjuv)
                {
                    if (ThiefInfo.ThiefFree(person)) // Om tjuv inte är fri
                    {
                        Tjuv prisonor = (Tjuv)person;
                        status[1] += 1;
                        if (!prisonor.WalkOfShame) // Kör walkofShame 1 gång
                        {
                            MovmentPrison.PrisonEnter(prisonor);
                            prisonor.WalkOfShame = true;
                        }

                        FlyttaPerson(person, 5, 20, 107, 129);

                        // MovmentPrison.FlyttaTjuv(person); // Flyttar Tjuv
                        ThiefInfo.ServeTime(prisonor);
                        if (prisonor.Fri)
                        {
                            MovmentPrison.PrisonExit(prisonor);
                        }

                    }
                    else // Om tjuv är fri
                    {
                        status[0] += 1;
                        FlyttaPerson(person, 5, 30, 1, 99);
                    }
                }
                else
                {
                    FlyttaPerson(person, 5, 30, 1, 99); //Flyttar medborgare
                }

                Console.SetCursorPosition(person.XPosition, person.YPosition);
                AddColor.SkrivUtPersonMedFärg(person);
                Console.ResetColor();
                BuildCity.FixWall();
            }
        }


        public static List<int> HämtaTillåtnaRiktningar(int citizenX, int citizenY, int yMin, int yMax, int xMin, int xMax)
        {
            List<int> tillåtnaRiktningar = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };

            if (citizenX <= xMin)
                tillåtnaRiktningar = new List<int> { 3, 5, 6 };

            else if (citizenX >= xMax)
                tillåtnaRiktningar = new List<int> { 2, 4, 7 };

            else if (citizenY <= yMin)  //ändra
                tillåtnaRiktningar = new List<int> { 1, 5, 7 };

            else if (citizenY >= (yMax - 1)) //ändra
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
        public static void FlyttaPerson(Person person, int yMin, int yMax, int xMin, int xMax)
        {
            List<int> tillåtnaRiktningar = HämtaTillåtnaRiktningar
                (person.XPosition, person.YPosition, yMin, yMax, xMin, xMax);

            if (tillåtnaRiktningar.Count < 8)
            {
                person.Riktning = SlumpaNyRiktning(tillåtnaRiktningar);
            }

            switch (person.Riktning)
            {
                case 0: person.YPosition--; break;
                case 1: person.YPosition++; break;
                case 2: person.XPosition--; break;
                case 3: person.XPosition++; break;
                case 4: person.YPosition--; person.XPosition--; break;
                case 5: person.YPosition++; person.XPosition++; break;
                case 6: person.YPosition--; person.XPosition++; break;
                case 7: person.YPosition++; person.XPosition--; break;
            }
        }


    }
}
