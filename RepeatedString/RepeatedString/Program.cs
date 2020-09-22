using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static long RepeatedString(string s, long n)
        {
            long min = n / s.Length;
            int rem =  (int) Math.Round((double) n % s.Length);

            long found = 0;
            foreach(var ch in s)
            {
                if (ch == 'a')
                    found++;
            }

            long count = found * min;
            if (rem == 0)
                return count;
            else
            {
                string part = s.Substring(0, rem);
                foreach (var ch in part)
                {
                    if (ch == 'a')
                        count++;
                }
            } 
                

            return count;
        }

        static void Main(string[] args)
        {
            string s = "kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm";
            long n = Convert.ToInt64("736778906400");
            //string s = "aba";
            //long n = Convert.ToInt64("10");

            long result = RepeatedString(s, n);

            Console.WriteLine(result);
        }
    }
}
