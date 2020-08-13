using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {
        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {

            var query = from bird
                        in arr
                        group bird by bird into g
                        let count = g.Count()
                        orderby count descending
                        select g.Key;

            return query.FirstOrDefault();

            //Alternative: 
            /*
                static void Main(String[] args)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    string[] types_temp = Console.ReadLine().Split(' ');
                    int[] types = Array.ConvertAll(types_temp, Int32.Parse);

                    int[] birdCounts = new int[6];

                    foreach (var type in types)
                        birdCounts[type]++;

                    int maxValue = birdCounts.Max();
                    int maxType = birdCounts.ToList().IndexOf(maxValue);

                    Console.WriteLine(maxType);
                }
            */
        }

        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
