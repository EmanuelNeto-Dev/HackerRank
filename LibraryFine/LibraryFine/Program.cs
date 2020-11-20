using System;

namespace LibraryFine
{
    class Program
    {
        // Complete the libraryFine function below.
        static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int fine = 0;

            DateTime returedDate = new DateTime(y1, m1, d1);
            DateTime dueDate = new DateTime(y2, m2, d2);

            var dateDiff = ((TimeSpan)(dueDate - returedDate));
            if (dateDiff.TotalSeconds > 0 || returedDate.Equals(dueDate))
            {
                return fine;
            }
            else if(dateDiff.Days < -1 && ((returedDate.Month == dueDate.Month) && (returedDate.Year == dueDate.Year)))
            {
                fine = 15 * (dateDiff.Days * -1);
            }
            else if (((returedDate.Month > dueDate.Month) && (returedDate.Year == dueDate.Year)))
            {
                fine = 500 * ((dueDate.Month - returedDate.Month) * -1);
            }
            else
            {
                fine = 10000;
            }


            return fine;

        }

        static void Main(string[] args)
        {
            //=>TestCase 0: 6 6 2015 9 6 2016
            //=>TestCase 7: 1 7 1010 1 1 1010
            //=>TestCase 4: 2 7 2014 1 1 2014
            string[] d1M1Y1 = "2 7 2014".Split(' ');
            int d1 = Convert.ToInt32(d1M1Y1[0]);
            int m1 = Convert.ToInt32(d1M1Y1[1]);
            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = "1 1 2014".Split(' ');
            int d2 = Convert.ToInt32(d2M2Y2[0]);
            int m2 = Convert.ToInt32(d2M2Y2[1]);
            int y2 = Convert.ToInt32(d2M2Y2[2]);

            int result = libraryFine(d1, m1, y1, d2, m2, y2);
            
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
