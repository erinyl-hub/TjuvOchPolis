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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            GameTopText.GameTextWelcome();
            GameTopText.GameTextPlayers();

            BuildCity.Border();
            BuildCity.Bana();
            BuildCity.BottomBorder();


            NewsFeed.NewsFeedMap();
            NewsFeed.NewsFeedBorder();
            NewsFeed.NewsFeedBottom();
            
            while (true)
            {

                Movment.Rörelse(citizens, messages);
                System.Threading.Thread.Sleep(200);
                NewsFeed.WriteMessages(messages);
                
            }
         
        }
    }
}
