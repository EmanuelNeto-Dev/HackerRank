using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static int beautifulDays(int i, int j, int k)
        {
            int days = 0;
            
            for (var index = i; index <= j; index++)
            {
                double number = (double) (index - ReverseTheNumber(index)) / k;

                if (number % 1 == 0)
                    days++;
            }

            return days;
        }

        private static int ReverseTheNumber(int number)
        {
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                number = number / 10;
            }

            return reversedNumber;
        }

        static void Main(string[] args)
        {
            string[] ijk = "20 23 6".Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);
        }
    }
}
