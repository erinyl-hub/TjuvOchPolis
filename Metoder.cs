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
                    x = Random.Shared.Next(0, 101);
                    y = Random.Shared.Next(0, 26);
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



    }
}








