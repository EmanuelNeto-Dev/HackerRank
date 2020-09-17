using System;
using System.Linq;

namespace AppendAndDelete
{
    class Program
    {
        // Complete the appendAndDelete function below.
        static string appendAndDelete(string s, string t, int k)
        {
            var common = string.Concat(s.TakeWhile((c, i) => t.Length > i && c == t[i])).Length;
            var diff = s.Length + t.Length - common * 2;
            var delta = k - diff;

            return s.Length + t.Length < k || delta >= 0 && delta % 2 == 0 ? "Yes" : "No";
        }


        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            string s = "qwerasdf";
            //string s = "ashley";

            //string t = Console.ReadLine();
            string t = "qwerbsdf";
            //string t = "ash";

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
