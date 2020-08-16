using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfProgrammer
{
    class Program
    {
        // Complete the dayOfProgrammer function below.
        static string dayOfTheProgrammer(int year)
        {
            if (year == 1918)
                return "26.09.1918";
            else if (((year <= 1917) && (year % 4 == 0)) || ((year > 1918) && (year % 400 == 0 || ((year % 4 == 0) && (year % 100 != 0)))))
                return $"12.09.{year}";
            else
                return $"13.09.{year}";

        }

        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfTheProgrammer(year);

            Console.WriteLine(result);
        }
    }
}
