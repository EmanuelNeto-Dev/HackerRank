using System;
using System.Collections.Generic;
using System.Linq;

/*
    Problem: https://www.hackerrank.com/challenges/between-two-sets
    Thoughts :
        1. Get the highest number present in set A. Let's call it maxA.
        2. Get the lowest number present in set B. Let's call it minB.
        3. Let the count of common Xs between set A and B be c. Initially set it to 0.
        4. Initialize a counter, co to 1.
        5. Run a loop while maxA <= minB
            5.1 Initialize a boolean, b to true.
            5.2 check if even a single element in set A is found which is not a factor of maxA then set b to false.
            5.3 if b is true then check if even a single element in set B is found for which maxA is not a factor then set b to false.
            5.4 If b is true then increment c by 1.
            5.5 increment co by 1.
            5.6 Set maxA to maxA * co.
            5.7 Continue iterating the loop until the termination condition is met.
        6. print c on a new line.
    Time Complexity:  O(x(n+m)) //where x = (max(m) - min(n))/min(n)
                                //Little tricky as the while loop is not purely iterative incrementing by 1 each time.
                            
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any number of elements in set A or B.
*/

namespace BetweenTwoSets
{
    class Program
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            var totalXs = 0;
            var maximumA = a.Max(); //Time-complexity O(n)
            var minimumB = b.Min(); //Time-complexity O(m)
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factorOfAll = true;

                foreach (var item in a) //Time complexity O(n)
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }

                if (factorOfAll)
                {
                    foreach (var item in b) //Time complexity O(m)
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maximumA * counter; //Here counter is the x factor which contributes to O(x(n+m)) complexity.
            }
            return totalXs;
        }

        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = getTotalX(arr, brr);

            Console.WriteLine(total);   
        }
    }
}
