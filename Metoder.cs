using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Metoder
    {
        public void AddCitizens(List<Person> citizens)
        {
            Name names = new Name();

            AddPersonToList(citizens, 10, names.polisnamn.ToList(), typeof(Polis));
            AddPersonToList(citizens, 20, names.tjuvnamn.ToList(), typeof(Tjuv));
            AddPersonToList(citizens, 30, names.medborgarnamn.ToList(), typeof(Medborgare));
        }

        public void AddPersonToList(List<Person> citizens, int antal, List<string> namnlista, Type typ)
        {
            for (int i = 0; i < antal; i++)
            {
                int x;
                int y;
                bool loopKey = false;

                
                do
                {
                    x = Random.Shared.Next(1, 101);
                    y = Random.Shared.Next(1, 26);
                    loopKey = PositionTest(citizens, x, y);

                } while (loopKey == false);

                
                string name = namnlista[i];
                int movement = Random.Shared.Next(0, 7);

                
                if (typ == typeof(Polis))
                {
                    Polis polis = new Polis(x, y, name, movement);
                    citizens.Add(polis);
                }
                else if (typ == typeof(Tjuv))
                {
                    Tjuv tjuv = new Tjuv(x, y, name, movement, true);
                    citizens.Add(tjuv);
                }
                else if (typ == typeof(Medborgare))
                {
                    Medborgare civilian = new Medborgare(x, y, name, movement);
                    citizens.Add(civilian);
                }
            }
        }

        public bool PositionTest(List<Person> citizens, int x, int y)
        {
            foreach (Person person in citizens)
            {
                if (person.XPosition == x && person.YPosition == y)
                {
                    return false; 
                }
            }
            return true; 
        }

        public void Rörelse(List<Person> citizens)
        {
            Random rand = new Random();

            foreach (Person person in citizens)
            {
                
                Console.SetCursorPosition(person.XPosition, person.YPosition);
                Console.Write(" ");

                
                List<int> tillåtnaRiktningar = HämtaTillåtnaRiktningar(person.XPosition, person.YPosition); 

                
                if (tillåtnaRiktningar.Count < 8) 
                {
                    person.Riktning = SlumpaNyRiktning(tillåtnaRiktningar, rand); 
                }

                
                FlyttaPerson(person); 

                
                Console.SetCursorPosition(person.XPosition, person.YPosition);
                SkrivUtPersonMedFärg(person); 
                Console.ResetColor();
            }
        }

        // NY METOD: Hämta tillåtna riktningar beroende på position
        private List<int> HämtaTillåtnaRiktningar(int x, int y)
        {
            List<int> tillåtnaRiktningar = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };

            if (x <= 1)
                tillåtnaRiktningar = new List<int> { 3, 5, 6 };

            else if (x >= 100)
                tillåtnaRiktningar = new List<int> { 2, 4, 7 };

            else if (y <= 1)
                tillåtnaRiktningar = new List<int> { 1, 5, 7 };

            else if (y >= 25)
                tillåtnaRiktningar = new List<int> { 0, 4, 6 };

            return tillåtnaRiktningar;
        }


        // NY METOD: Slumpa en ny riktning från de tillåtna
        private int SlumpaNyRiktning(List<int> tillåtnaRiktningar, Random rand)
        {
            return tillåtnaRiktningar[rand.Next(tillåtnaRiktningar.Count)];
        }


        // NY METOD: Flytta personen baserat på riktningen
        private void FlyttaPerson(Person person)
        {
            switch (person.Riktning)
            {
                case 0: if (person.YPosition > 1) person.YPosition--; break;
                case 1: if (person.YPosition < 25) person.YPosition++; break;
                case 2: if (person.XPosition > 1) person.XPosition--; break;
                case 3: if (person.XPosition < 100) person.XPosition++; break;
                case 4: if (person.YPosition > 1 && person.XPosition > 1) { person.YPosition--; person.XPosition--; } break;
                case 5: if (person.YPosition < 25 && person.XPosition < 100) { person.YPosition++; person.XPosition++; } break;
                case 6: if (person.YPosition > 1 && person.XPosition < 100) { person.YPosition--; person.XPosition++; } break;
                case 7: if (person.YPosition < 25 && person.XPosition > 1) { person.YPosition++; person.XPosition--; } break;
            }
        }


        // NY METOD. Det är den gamla koden men i en metod istället
        private void SkrivUtPersonMedFärg(Person person)
        {
            if (person is Polis)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (person is Tjuv)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (person is Medborgare)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write(PersonMarkering(person));
        }

        public char PersonMarkering(Person person)
        {
            if (person is Polis) return 'P';
            else if (person is Tjuv) return 'T';
            else if (person is Medborgare) return 'C';

            return ' ';
        }
    }
}











