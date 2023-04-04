using System;

namespace _05_UbiDubi
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            // Vowels array
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            //Find the index of your first vowel in your 'word'
            int index = word.IndexOfAny(vowels);

            //Insert 'ub' at above location
            word = word.Insert(index, "ub");

            Console.WriteLine(word);
        }
    }
}
