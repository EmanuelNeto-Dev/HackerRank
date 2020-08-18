using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class Program
    {
        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            bool fairly = false;
            int calculation = 0,
                refunds = 0;

            for (int i = 0; i < bill.Count(); i++)
            {
                if (!k.Equals(null) && i == k)
                    continue;

                calculation += bill[i];
            }

            if (calculation / 2 == b)
                fairly = true;
            else
                refunds = b - calculation / 2;

            if (fairly)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(refunds);
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
    }
}
