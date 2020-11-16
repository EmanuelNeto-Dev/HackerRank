using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceEquation
{
    class Program
    {
        static int[] permutationEquation(int[] p)
        {
            var listWithZero = new List<int>();
            var result = new List<int>();

            listWithZero.Add(0);

            foreach(var item in p)
            {
                listWithZero.Add(item);
            }

            for(int i = 1; i < listWithZero.Count(); i++)
            {
                int numOfInd = listWithZero.IndexOf(listWithZero.IndexOf(i));
                result.Add(numOfInd);
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll("5 2 1 3 4".Split(' '), pTemp => Convert.ToInt32(pTemp));

            int[] result = permutationEquation(p);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadKey();
        }
    }
}
