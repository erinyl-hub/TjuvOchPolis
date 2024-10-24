using System.ComponentModel;

namespace TjuvOchPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metoder metoder = new Metoder();
            List <Person> citizens = new List <Person> ();
            metoder.AddCitizens(citizens);


            //asfd

            //foreach (Person person in citizens)
            //{
            //    
            //    if (person is Polis polis)
            //    {
            //        Console.WriteLine($"{polis.Name} {polis.XPosition} {polis.YPosition} {polis.Riktning} {polis.Id}");
            //    }
            //    else if (person is Tjuv tjuv)
            //    {
            //        Console.WriteLine($"{tjuv.Name} {tjuv.XPosition} {tjuv.YPosition} {tjuv.Riktning} {tjuv.Id} {tjuv.Fri}");
            //    }
            //    else if (person is Medborgare civilian)
            //    {
            //        Console.WriteLine($"{civilian.Name} {civilian.XPosition} {civilian.YPosition} {civilian.Riktning} {civilian.Id}");
            //    }
            //}


            TjuvOchPolis.Border();
            TjuvOchPolis.Bana(citizens);
            TjuvOchPolis.Border();

            Console.ReadKey();
        }
    }
}
