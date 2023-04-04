using System;

namespace _04_Palindromee
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reverseWord = string.Empty;

            for (int i = word.Length - 1; 0<=i; i--)
            {
                reverseWord = reverseWord + word[i];
            }

            if (word==reverseWord)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
