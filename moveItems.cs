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
                    }
                    break;
                case 1:
                    if (medborgare.Belongings.Mobil > 0)
                    {
                        medborgare.Belongings.Mobil--;
                        tjuv.StolenGoods.Mobil++;                       
                    }
                    break;
                case 2:
                    if (medborgare.Belongings.Money > 0)
                    {
                        medborgare.Belongings.Money--;
                        tjuv.StolenGoods.Money++;                    
                    }
                    break;
                case 3:
                    if (medborgare.Belongings.Watch > 0)
                    {
                        medborgare.Belongings.Watch--;
                        tjuv.StolenGoods.Watch++;                       
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
                polis.SeizedGoods.Key += tjuv.StolenGoods.Key;
                polis.SeizedGoods.Mobil += tjuv.StolenGoods.Mobil;
                polis.SeizedGoods.Money += tjuv.StolenGoods.Money;
                polis.SeizedGoods.Watch += tjuv.StolenGoods.Watch;

                tjuv.StolenGoods.Key = 0; // Skriva om så det blir snyggare?
                tjuv.StolenGoods.Mobil = 0;
                tjuv.StolenGoods.Money = 0;
                tjuv.StolenGoods.Watch = 0;
                tjuv.Fri = false;
            }
            return;
        }
    }
}

