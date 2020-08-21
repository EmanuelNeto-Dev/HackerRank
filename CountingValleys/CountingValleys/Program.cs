using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int quantityOfValleys = 0;
            int levelToTheSeaActual = 0;

            if (!s.Contains('D'))
                return 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('U'))
                {
                    levelToTheSeaActual++;
                }
                else if (s[i].Equals('D') && levelToTheSeaActual == 0)
                {
                    levelToTheSeaActual--;
                    quantityOfValleys++;
                }
                else
                {
                    levelToTheSeaActual--;
                }
            }

            return quantityOfValleys;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int result = countingValleys(n, s);

            Console.WriteLine(result);

        }
    }
}
