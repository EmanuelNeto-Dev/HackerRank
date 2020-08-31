using System;

namespace SaveThePrisoner
{
    class Program
    {
        static int saveThePrisoner(int numOfPrisoners, int sweets, int pos)
        {
            int prisonerId = (pos + (sweets - 1)) % numOfPrisoners;
            return prisonerId == 0 ? numOfPrisoners : prisonerId;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);
                int m = Convert.ToInt32(nms[1]);
                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }
        }
    }
}
