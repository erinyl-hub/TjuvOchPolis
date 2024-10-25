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

            for (int i = 0; i < 10; i++) // Gör till en metod
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


                string name = names.polisnamn[i];
                int movement = Random.Shared.Next(0, 7);

                Polis polis = new Polis(x, y, name, movement);


                citizens.Add(polis);
            }

            for (int i = 0; i < 20; i++)
            {
                int x;
                int y;
                bool loopKey = false;
                do
                {
                    x = Random.Shared.Next(1, 10);
                    y = Random.Shared.Next(1, 26);
                    loopKey = PositionTest(citizens, x, y);
                } while (loopKey == false);


                string name = names.tjuvnamn[i];
                int movement = Random.Shared.Next(0, 7);

                Tjuv tjuv = new Tjuv(x, y, name, movement, true);


                citizens.Add(tjuv);
            }


            for (int i = 0; i < 30; i++)
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



                string name = names.medborgarnamn[i];
                int movement = Random.Shared.Next(0, 7);

                Medborgare civilian = new Medborgare(x, y, name, movement);


                citizens.Add(civilian);
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


                Console.SetCursorPosition(person.XPosition, person.YPosition);
                Console.Write(PersonMarkering(person));
            }

        }

        public char PersonMarkering(Person person)
        {
            if (person is Polis) return 'P';


            if (person is Tjuv) return 'T';


            if (person is Medborgare) return 'C';

            return ' ';
        }
    }
}









