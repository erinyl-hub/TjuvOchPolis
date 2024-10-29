using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Meeting
    {
        public static void PersonMeeting(List<Person> citizens) // static
        {

            for (int i = 0; i < citizens.Count; i++)
            {
                for(int j = 0; j < citizens.Count; j++)
                {
                    if (i == j)  break; // inte möter sig själv
                    

                    Person person = citizens[i];
                    Person personMeeting = citizens[j];

                    // kollar om personen i och j är på samma potition
                    if (person.YPosition == personMeeting.YPosition && person.XPosition == personMeeting.XPosition)
                    {
                        Type typ = person.GetType();
                        Type typMeeting = personMeeting.GetType();

                        if (typ == typeof(Medborgare) && typMeeting == typeof(Tjuv))
                        {
                            Console.Clear();
                            Console.WriteLine("Funkar");
                            Console.ReadKey();
                        }

                        if (typ == typeof(Polis) && typMeeting == typeof(Tjuv))
                        {
                            Console.Clear();
                            Console.WriteLine("Funkar");
                            Console.ReadKey();
                        }

                        if (typ == typeof(Polis) && typMeeting == typeof(Polis))
                        {
                            Console.Clear();
                            Console.WriteLine("Funkar");
                            Console.ReadKey();
                        }

                    }



                    //Type typ = person.GetType();
                    //Type typMeeting = personMeeting.GetType();

                    //if (typ == typeof(Medborgare) && typMeeting == typeof(Tjuv))
                    //{
                    //    Console.Clear();
                    //    Console.WriteLine("Funkar");
                    //    Console.ReadKey();
                    //}





                }
            }


        }


    }
}
