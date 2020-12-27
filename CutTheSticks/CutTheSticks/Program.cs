using System;
using System.Collections.Generic;
using System.Linq;

namespace CutTheSticks
{
    public class Program
    {
        // Complete the cutTheSticks function below.
        static int[] cutTheSticks(int[] arr)
        {
            var lstResult = new List<int>()
            {
                arr.Length
            };


            while (arr.Length > 1)
            {
                var lwst = arr.Min();
                var lst = (from s
                           in arr
                           select s - lwst).Where(s => !s.Equals(0));

                lstResult.Add(lst.Count());

                arr = lst.ToArray();
            }

            return lstResult.Where(s => !s.Equals(0)).ToArray();
        }

        static void Main(string[] args)
        {
            #region Test Cases

            //8
            //8 8 14 10 3 5 14 12

            //6
            //5 4 4 2 2 8

            #endregion

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] result = cutTheSticks(arr);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
