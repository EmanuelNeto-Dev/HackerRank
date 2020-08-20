using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static int pageCount(int n, int p)
        {
            if (p == 1 || n == p)
                return 0;

            int minimumTurnedPages;

            if (p - 1 < n - p)
            {
                double upfront = Math.Truncate((double)p / 2);
                minimumTurnedPages = Convert.ToInt32(upfront);
            }
            else if (n % 2 == 0 && n - 1 == p)
            {
                return 1;
            }
            else
            {
                double upback = Math.Truncate((double)(n - p) / 2);
                minimumTurnedPages = Convert.ToInt32(upback);
            }

            return minimumTurnedPages;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
