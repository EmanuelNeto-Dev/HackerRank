using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse
{
    class Program
    {
        static string catAndMouse(int x, int y, int z)
        {
            string first = "";
            int distanceFromA = z - x >= 0 ? z - x : (z - x) * -1;
            int distanceFromB = z - y >= 0 ? z - y : (z - y) * -1;

            if (distanceFromA < distanceFromB)
            {
                first = "Cat A";
            }
            else if (distanceFromA == distanceFromB)
            {
                first = "Mouse C";
            }
            else
            {
                first = "Cat B";
            }

            return first;

        }

        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }

        }
    }
}
