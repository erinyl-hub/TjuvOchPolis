using System.ComponentModel;

namespace TjuvOchPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            List<Person> citizens = new List<Person>();
            CreateCitizens.AddCitizens(citizens);

            BuildCity.Border();
            BuildCity.Bana(citizens);
            BuildCity.Border();

            while (true)
            {
                Movment.Rörelse(citizens);
                System.Threading.Thread.Sleep(1);
            }
         
        }
    }
}
