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
                    x = Random.Shared.Next(0, 101);
                    y = Random.Shared.Next(0, 26);
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
                    x = Random.Shared.Next(0, 101);
                    y = Random.Shared.Next(0, 26);
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
                    x = Random.Shared.Next(0, 101);
                    y = Random.Shared.Next(0, 26);
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


    }
}








