using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class MoveItems
    {

        public static void ThiefCitizenItems(Tjuv tjuv, Medborgare medborgare)
        {
            int rnd = Random.Shared.Next(0, 4);

            switch (rnd)
            {
                case 0:
                  if (medborgare.Belongings.Key > 0)
                    {
                        medborgare.Belongings.Key--;
                        tjuv.StolenGoods.Key++;
                        Console.WriteLine($"{tjuv.Name} stal en nyckel ifrån {medborgare.Name}");
                    }
                    break;
                case 1:
                    if (medborgare.Belongings.Mobil > 0)
                    {
                        medborgare.Belongings.Mobil--;
                        tjuv.StolenGoods.Mobil++;
                        Console.WriteLine($"{tjuv.Name} stal en mobil ifrån {medborgare.Name}");
                    }
                    break;
                case 2:
                    if (medborgare.Belongings.Money > 0)
                    {
                        medborgare.Belongings.Money--;
                        tjuv.StolenGoods.Money++;
                        Console.WriteLine($"{tjuv.Name} stal pengar ifrån {medborgare.Name}");
                    }
                    break;
                case 3:
                    if (medborgare.Belongings.Watch > 0)
                    {
                        medborgare.Belongings.Watch--;
                        tjuv.StolenGoods.Watch++;
                        Console.WriteLine($"{tjuv.Name} stal en klocka ifrån {medborgare.Name}");
                    }
                    break;


                default:
                    break;



            }



        }

        
        public static void PoliceThiefItems(Tjuv tjuv, Polis polis)
        {
            
            if (tjuv.StolenGoods.Key > 0 || tjuv.StolenGoods.Watch > 0 || tjuv.StolenGoods.Money > 0 || tjuv.StolenGoods.Mobil > 0)
            {
                int key = tjuv.StolenGoods.Key;
                int watch = tjuv.StolenGoods.Watch;
                int money = tjuv.StolenGoods.Money;
                int mobil = tjuv.StolenGoods.Mobil;
                polis.SeizedGoods.Key += key;
                polis.SeizedGoods.Mobil += mobil;
                polis.SeizedGoods.Money += money;
                polis.SeizedGoods.Watch += watch;
                tjuv.Fri = false;
            }
            return;
        }
    }
}

