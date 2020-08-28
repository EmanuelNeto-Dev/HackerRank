using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickingNumbers
{
    class Result
    {

        public static int pickingNumbers(List<int> a)
        {
            var lngSize = 0;
            var orderedList = a.OrderByDescending(n => n).ToList();

            for (int i = 0; i < orderedList.Count(); i++)
            {
                var maxNumList = new List<int>
                {
                    orderedList[i]
                };  
                
                for (int j = i + 1; j < orderedList.Count(); j++)
                {
                    if (orderedList[i] - orderedList[j] <= 1)
                        maxNumList.Add(orderedList[j]);

                }

                lngSize = maxNumList.Count() > lngSize ? maxNumList.Count() : lngSize;
            }

            return lngSize;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32("6".Trim());

            List<int> a = "4 6 5 3 3 1".TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.pickingNumbers(a);

            Console.WriteLine(result);
        }
    }
}
