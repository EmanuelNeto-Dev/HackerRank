using System;

namespace SherlockAndSquares
{
    class Program
    {
        // Complete the squares function below.
        static int squares(int a, int b)
        {
            #region Way 1 - Works but it is more slow.
            // int quantityOfSquares = 0;
            // for(int i = a; i <= b; i++)
            // {
            //     if(Math.Sqrt(i) % 1 == 0)
            //         quantityOfSquares++;

            // }
            // return quantityOfSquares;
            #endregion

            //Way 2 - More effective
            return (int)(Math.Floor(Math.Sqrt(b)) - Math.Ceiling(Math.Sqrt(a)) + 1);

        }

        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);

                Console.WriteLine(result);
            }
        }
    }
}
