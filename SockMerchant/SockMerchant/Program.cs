using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int quantidadeDeMeias, int[] meias)
        {
            Array.Sort(meias);

            int paresDeMeia = 0;
            int meiaSozinha = 0;

            for (int i = 0; i < quantidadeDeMeias; i++)
            {
                if (meiaSozinha == meias[i])
                {
                    paresDeMeia++;
                    meiaSozinha = 0;
                }
                else
                {
                    meiaSozinha = meias[i];
                }
            }

            return paresDeMeia;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
