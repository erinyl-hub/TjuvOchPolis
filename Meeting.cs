using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Meeting
    {
        public static void PersonMeeting(List<Person> citizens, List<string> messages, int[] status) // static
        {
            for (int i = 0; i < citizens.Count; i++)
            {
                for (int j = 0; j < citizens.Count; j++)
                {
                    if (i == j) break; // inte möter sig själv

                    Person person = citizens[i];
                    Person personMeeting = citizens[j];

                    // kollar om personen i och j är på samma potition
                    if (person.YPosition == personMeeting.YPosition && person.XPosition == personMeeting.XPosition)
                    {
                        Type typ = person.GetType();
                        Type typMeeting = personMeeting.GetType();

                        if (typ == typeof(Medborgare) && typMeeting == typeof(Tjuv))
                        {
                            Tjuv thief = (Tjuv)personMeeting;
                            Medborgare citizen = (Medborgare)person;
                            MoveItems.ThiefCitizenItems(thief, citizen, messages, status);

                        }

                        else if (typ == typeof(Tjuv) && typMeeting == typeof(Polis))
                        {
                            Tjuv thief = (Tjuv)person;
                            Polis polis = (Polis)personMeeting;
                            MoveItems.PoliceThiefItems(thief, polis);
                        }

                        if (typ == typeof(Polis) && typMeeting == typeof(Polis))
                        {
                            Polis polis1 = (Polis)person;
                            Polis polis2 = (Polis)personMeeting;
                            NewsFeed.PoliceMsg(messages, polis1, polis2);
                            status[3]++;
                        }
                    }
                }
            }
        }
    }
}
