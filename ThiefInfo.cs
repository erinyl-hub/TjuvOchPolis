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
    }
}
