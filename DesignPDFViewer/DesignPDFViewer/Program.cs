using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPDFViewer
{
    class Program
    {
        // Complete the designerPdfViewer function below.
        static int DesignerPdfViewer(int[] h, string word)
        {
            int areaSize = 0;
            var alphabbet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
            //char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var dicLetter = new Dictionary<int, int>();

            for (int i = 0; i < alphabbet.Length; i++)
            {
                dicLetter.Add(alphabbet[i], h[i]);
            }

            string newWord = "";
            for (int j = 0; j < word.Length; j++)
            {
                newWord += $"{dicLetter[word[j]]}";
            }

            string heightest = newWord.Max().ToString();
            areaSize = Convert.ToInt32(heightest) * word.Length;

            return areaSize;
        }

        static void Main(string[] args)
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = DesignerPdfViewer(h, word);

            Console.WriteLine(result);
        }
    }
}
