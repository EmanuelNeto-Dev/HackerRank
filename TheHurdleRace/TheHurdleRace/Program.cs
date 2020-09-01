using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHurdleRace
{
    class Program
    {
        static int hurdleRace(int k, int[] heights)
        {
            int doses = 0;

            Array.Sort(heights);
            var query = (from height
                         in heights
                         where height > k
                         select height);

            foreach (var item in query)
            {
                if (k < item)
                    doses++;
                k++;
            }

            return doses;
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);

            Console.WriteLine(result);
        }
    }
}
