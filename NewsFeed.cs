using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class NewsFeed
    {
        public static void AddMessages(List<string> messages, Tjuv tjuv, Medborgare medborgare, string goods)
        {
            string message = $"{tjuv.Name} tog en {goods} ifrån {medborgare.Name}";
            messages.Add(message);

        }

        public static void WriteMessages(List<string> messages)
        {
            
            Console.SetCursorPosition(0,27);
            int startIndex = Math.Max(messages.Count - 5, 0);

            for (int i = messages.Count - 1; i >= startIndex; i--) 
            {
                
                Console.WriteLine(i + " - " + messages[i]+ "         ");
                
            }
            
        }
    }
}
