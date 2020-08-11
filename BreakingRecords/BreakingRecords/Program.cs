using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingRecords
{
    class Program
    {
        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int highestScore = 0;
            int lowestScore = 0;
            int counterMax = 0;
            int counterMin = 0;

            for (int i = 0; i < scores.Length; i++)
            {

                if (i == 0)
                {
                    highestScore = scores[i];
                    lowestScore = scores[i];
                    continue;
                }

                if (scores[i] > highestScore)
                {
                    highestScore = scores[i];
                    counterMax++;
                }
                else if (scores[i] < lowestScore)
                {
                    lowestScore = scores[i];
                    counterMin++;
                }

            }

            int[] breakedRecords = { counterMax, counterMin };
            return breakedRecords;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
