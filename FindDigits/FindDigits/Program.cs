using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static int findDigits(int n)
        {
            int digits = 0;
            string digitConverted = n.ToString();

            for (int i = 0; i < digitConverted.Length; i++)
            {
                if (digitConverted[i].Equals('0'))
                    continue;

                if (n % int.Parse(digitConverted[i].ToString()) == 0)
                    digits++;
            }

            return digits;
        } 

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int result = findDigits(n);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
