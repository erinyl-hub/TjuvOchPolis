using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

                // Hitta en giltig position
                do
                {
                    x = Random.Shared.Next(1, 101);
                    y = Random.Shared.Next(1, 26);
                    loopKey = PositionTest(citizens, x, y);

                } while (loopKey == false);

                // Slumpa fram ett namn och rörelse
                string name = namnlista[i];
                int movement = Random.Shared.Next(0, 7);

                // Skapa rätt typ av person och lägg till i listan
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
                    return false; // Positionen är upptagen
                }
            }
            return true; // Positionen är ledig
        }


        public void Rörelse(List<Person> citizens)
        {
            foreach (Person person in citizens)
            {

                Console.SetCursorPosition(person.XPosition, person.YPosition);
                Console.Write(" ");


                int direction = person.Riktning;

                switch (direction)
                {
                    case 0:
                        if (person.YPosition > 1 && person.XPosition < 100)
                            person.YPosition--;
                        break;

                    case 1:
                        if (person.YPosition < 25) person.YPosition++;
                        break;

                    case 2:
                        if (person.XPosition > 1) person.XPosition--;
                        break;

                    case 3:
                        if (person.XPosition < 100) person.XPosition++;
                        break;

                    case 4:
                        if (person.YPosition > 1 && person.XPosition > 1) // flyttar vänster uppåt
                        { person.YPosition--; person.XPosition--; };
                        break;

                    case 5:
                        if (person.YPosition < 25 && person.XPosition < 100) // flyttar höger neråt
                        { person.YPosition++; person.XPosition++; };
                        break;

                    case 6:
                        if (person.YPosition > 1 && person.XPosition < 100) // flyttar höger uppåt
                        { person.YPosition--; person.XPosition++; };
                        break;

                    case 7:
                        if (person.YPosition < 25 && person.XPosition > 1) // flyttar vänster neråt
                        { person.YPosition++; person.XPosition--; };
                        break;
                }


                if (person is Polis)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;  // har färgen kvar när den loopar
                }
                else if (person is Tjuv)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (person is Medborgare)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }


                Console.SetCursorPosition(person.XPosition, person.YPosition);
                Console.Write(PersonMarkering(person));






            }

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










