using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    public class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var numberOfApples = 0;
            var numberOfOranges = 0;
            
            for (int i = 0; i < apples.Length; i++)
            {
                var finalPositionApple = a + apples[i];
                if (finalPositionApple >= s && finalPositionApple <= t)
                {
                    numberOfApples++;
                }
            }

            for (int j = 0; j < oranges.Length; j++)
            {
                var finalPositionOrange = b + oranges[j];
                if (finalPositionOrange >= s && finalPositionOrange <= t)
                {
                    numberOfOranges++;
                }
            }

            Console.WriteLine($"{numberOfApples}");
            Console.WriteLine($"{numberOfOranges}");
        }

        static void Main(string[] args)
        {
            //7 11
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            //5 15
            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            //3 2
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            //-2 2 1
            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            //5 -6
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
