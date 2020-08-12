using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            int totalNumberOfWays = 0;

            for (int i = 0; i < s.Count(); i++)
            {
                if (i + m > s.Count())
                {
                    continue;
                }
                int sum = s.Skip(i).Take(m).Sum();
                if (sum == d)
                {
                    totalNumberOfWays++;
                }
            }

            return totalNumberOfWays;

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
