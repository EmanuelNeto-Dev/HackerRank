using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EletronicsShop
{
    class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int monicaBudget)
        {
            int maximumTotalPrice = 0;
            bool canAfford = false;

            Array.Reverse(keyboards);
            Array.Reverse(drives);

            int[] biggestList;
            int[] shortestList;

            if (keyboards.Length > drives.Length)
            {
                biggestList = keyboards;
                shortestList = drives;
            }
            else
            {
                biggestList = drives;
                shortestList = keyboards;
            }

            for (int i = 0; i < biggestList.Length; i++)
            {
                for (int j = 0; j < shortestList.Length; j++)
                {
                    int price = biggestList[i] + shortestList[j];
                    if (price > maximumTotalPrice && price <= monicaBudget)
                    {
                        maximumTotalPrice = price;
                        canAfford = true;
                    }
                }
            }

            if (!canAfford)
                return -1;


            return maximumTotalPrice;

        }

        static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);

        }
    }
}
