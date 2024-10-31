using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;

namespace TjuvOchPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            List<Person> citizens = new List<Person>();
            CreateCitizens.AddCitizens(citizens);
            List<string> messages = new List<string>();

            BuildCity.Border();
            BuildCity.Bana();
            BuildCity.Border();

            
            NewsFeed.NewsFeedMap();
            NewsFeed.NewsFeedBorder();

            while (true)
            {
                
                Movment.Rörelse(citizens, messages);
                System.Threading.Thread.Sleep(250);
                NewsFeed.WriteMessages(messages);
                
            }
         
        }
    }
}
