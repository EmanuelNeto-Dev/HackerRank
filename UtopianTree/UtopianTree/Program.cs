using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {
        // Complete the utopianTree function below.
        static int utopianTree(int n)
        {
            int height = 1;

            if (n == 0)
                return 1;

            if (n == 1)
                return 2;

            int contador = 1;
            while (contador <= n)
            {
                height = contador % 2 == 0 ? height + 1 : height * 2;
                contador++;
            }

            return height;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
