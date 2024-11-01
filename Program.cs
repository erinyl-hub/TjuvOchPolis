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
            int[] status = new int[4];

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
            NewsFeed.StatusText();


            while (true)
            {
                GameTopText.GamePlayerPress(citizens, messages, status);

            }

            

           

        }
    }
}
