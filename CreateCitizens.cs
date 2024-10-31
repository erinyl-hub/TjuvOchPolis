using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class CreateCitizens
    {

        public static void AddCitizens(List<Person> citizens)
        {
            Name names = new Name();

            AddPersonToList(citizens, 10, names.polisnamn.ToList(), typeof(Polis));
            AddPersonToList(citizens, 20, names.tjuvnamn.ToList(), typeof(Tjuv));
            AddPersonToList(citizens, 30, names.medborgarnamn.ToList(), typeof(Medborgare));
        }

        public static void AddPersonToList(List<Person> citizens, int antal, List<string> namnlista, Type typ)
        {
            for (int i = 0; i < antal; i++)
            {
                int x;
                int y;
                bool loopKey = false;

                //En do-while-loop som fortsätter att köra så länge loopKey är false. 
                //Den används för att generera nya koordinater x och y tills en ledig position hittas.
                do
                {
                    x = Random.Shared.Next(1, 101);
                    y = Random.Shared.Next(1, 26);

                    //Kallar metoden PositionTest för att kontrollera om den slumpmässiga positionen redan är upptagen av en annan medborgare.
                    loopKey = PositionTest(citizens, x, y);

                } while (loopKey == false);


                string name = namnlista[i];
                int movement = Random.Shared.Next(0, 7);


                if (typ == typeof(Polis))
                {
                    Inventory inventory = new Inventory(0, 0, 0, 0);
                    Polis polis = new Polis(inventory, x, y, name, movement);
                    citizens.Add(polis);
                }
                else if (typ == typeof(Tjuv))
                {
                    Inventory inventory = new Inventory(0, 0, 0, 0);
                    Tjuv tjuv = new Tjuv(inventory, x, y, name, movement, true);
                    citizens.Add(tjuv);
                }
                else if (typ == typeof(Medborgare))
                {
                    Inventory inventory = new Inventory(1, 1, 1, 1);
                    Medborgare civilian = new Medborgare(inventory, x, y, name, movement);
                    citizens.Add(civilian);
                }
            }
        }

        public static bool PositionTest(List<Person> citizens, int x, int y)
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
