using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class MoveItems
    {
        public static List<int> CheckInventory(Medborgare medborgare)
        {
            List<int> inventory = new List<int>();
            if (medborgare.Belongings.Key == 1)
            {
                inventory.Add(0);
            }
            if (medborgare.Belongings.Mobil == 1)
            {
                inventory.Add(1);
            }
            if (medborgare.Belongings.Money == 1)
            {
                inventory.Add(2);
            }
            if (medborgare.Belongings.Watch == 1)
            {
                inventory.Add(3);
            }
            return inventory;
        }

        public static void ThiefCitizenItems(Tjuv tjuv, Medborgare medborgare, List<string> messages, int[] status)
        {
            List<int> inventory = CheckInventory(medborgare);

            if (inventory.Count == 0)
            {
                return;
            }
            else 
            {
                int rnd = Random.Shared.Next(0, inventory.Count);

                int choice = inventory[rnd];

                string goods;

                switch (choice)
                {

                    case 0:                                             
                            goods = "nyckel";
                            medborgare.Belongings.Key--;
                            tjuv.StolenGoods.Key++;
                            tjuv.SentenceTime += 30;
                            NewsFeed.AddMessages(messages, tjuv, medborgare, goods);
                            status[2]++;

                        break;
                    case 1:                                              
                            goods = "mobil";
                            medborgare.Belongings.Mobil--;
                            tjuv.StolenGoods.Mobil++;
                            tjuv.SentenceTime += 30;
                            NewsFeed.AddMessages(messages, tjuv, medborgare, goods);
                            status[2]++;
                        
                        break;
                    case 2:                       
                            goods = "plånbok";
                            medborgare.Belongings.Money--;
                            tjuv.StolenGoods.Money++;
                            tjuv.SentenceTime += 30;
                            NewsFeed.AddMessages(messages, tjuv, medborgare, goods);
                            status[2]++;
                        
                        break;
                    case 3:                       
                            goods = "klocka";
                            medborgare.Belongings.Watch--;
                            tjuv.StolenGoods.Watch++;
                            tjuv.SentenceTime += 30;
                            NewsFeed.AddMessages(messages, tjuv, medborgare, goods);
                            status[2]++;
                        
                        break;

                    default:

                        break;
                }
                if (medborgare.Belongings.Money != 1 && medborgare.Belongings.Watch != 1 && medborgare.Belongings.Key != 1 && medborgare.Belongings.Mobil != 1)
                {
                    NewsFeed.PoorMsg(messages, medborgare);
                }
            }
        }

        
        public static void PoliceThiefItems(Tjuv tjuv, Polis polis, List<string> messages)
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

                NewsFeed.PoliceCatchThiefMsg(messages, polis, tjuv);
            }
            return;
        }
        
    }
}

