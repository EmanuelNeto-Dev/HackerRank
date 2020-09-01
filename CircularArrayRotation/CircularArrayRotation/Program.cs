using System;

namespace CircularArrayRotation
{
    class Program
    {
        // Complete the circularArrayRotation function below.
        static int[] CircularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] arr = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                arr[(i + k) % a.Length] = a[i];
            }
                

            for (int i = 0; i < queries.Length; i++)
                queries[i] = arr[queries[i]];

            return queries;
        }

        //private static int[] RotateArray(int[] arrayOriginal)
        //{
        //    var temp = new List<int>();
        //    int posicion = arrayOriginal.Length - 1;
        //    temp.Add(arrayOriginal[posicion]);

        //    return temp.Concat(arrayOriginal.Except(temp)).ToArray();
        //}

        static void Main(string[] args)
        {
            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);

            int k = Convert.ToInt32(nkq[1]);

            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            int[] result = CircularArrayRotation(a, k, queries);

            Console.WriteLine(string.Join("\n", result));

        }
    }
}

