using System;

namespace ViralAdvertising
{
    class Program
    {
        static int ViralAdvertising(int day)
        {
            int cumulative = 0;
            int shared = 5;
            
            for (int i = 1; i <= day; i++)
            {
                var liked = Convert.ToInt32(Math.Floor((double)shared / 2));
                shared = liked * 3;
                cumulative += liked;
            }

            return cumulative;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = ViralAdvertising(n);

            Console.WriteLine(result);

        }
    }
}
