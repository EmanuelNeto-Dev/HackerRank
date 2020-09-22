using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds_2
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            
            int position = 0;
            while (position < c.Length - 1)
            {
                if (position + 1 == c.Length - 1)
                    position += 1;
                else if (c[position + 2] == 1)
                    position += 1;
                else
                    position += 2;

                jumps++;
            }

            return jumps;
        }

        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32("10");

            //int[] c = Array.ConvertAll("0 0 0 0 1 0".Split(' '), cTemp => Convert.ToInt32(cTemp));
            //int[] c = Array.ConvertAll("0 0 1 0 0 1 0".Split(' '), cTemp => Convert.ToInt32(cTemp));
            int[] c = Array.ConvertAll("0 0 1 0 0 0 0 1 0 0".Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
