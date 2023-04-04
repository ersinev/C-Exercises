using System;
using System.Text.RegularExpressions;

namespace _06_CountOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string test = Console.ReadLine();
            int wordCount = 0;
            foreach (Match m in Regex.Matches(test, word))
            {
                wordCount++;
            }

            Console.WriteLine(wordCount);
        }
    }
}
