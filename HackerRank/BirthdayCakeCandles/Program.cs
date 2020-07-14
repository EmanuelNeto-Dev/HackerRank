using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int BirthdayCakeCandles(int[] ar)
        {
            var result = 0;
            var tallerCandle = ar.Max();

            if (ar.Length == 0)
                return result;

            result = ar.Count(c => c == tallerCandle);

            return result;
        }

        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = BirthdayCakeCandles(ar);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
