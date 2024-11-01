using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class ThiefInfo
    {     
        public static bool ThiefFree(Person person)
        {          
            Tjuv thief = (Tjuv)person;

            if (thief.Fri == true)
            {
                return false;
            }
            else
                return true;
        }
        public static void ServeTime(Tjuv tjuv)
        {

                if (tjuv.SentenceTime > 0)
                {
                tjuv.SentenceTime--;
                }
                if (tjuv.SentenceTime == 0)
                {
                    tjuv.Fri = true;
                    tjuv.WalkOfShame = false;
                }
            

        }
    }
}
