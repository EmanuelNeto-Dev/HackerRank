using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndryProfessor
{
    class Program
    {
        static string angryProfessor(int cancellation, int[] a)
        {

            var query = (from student
                         in a
                         where student <= 0
                         select student).Count();

            return query < cancellation ? "YES" : "NO";

        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

                string result = angryProfessor(k, a);

                Console.WriteLine(result);
            }
        }
    }
}
