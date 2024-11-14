using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;

namespace TjuvOchPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Thieves and Cops: Sleepless City";
            List<Person> citizens = new List<Person>();
            CreateCitizens.AddCitizens(citizens);
            List<string> messages = new List<string>();
            int[] status = new int[4];

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            GameTopText.GenerateGame(citizens, messages, status);
          
            while (true)
            {
                GameTopText.GamePlayerPress(citizens, messages, status);

            }
        }
    }
}
