using System;

namespace _06_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchText = Console.ReadLine();
            var input = Console.ReadLine();
            var arr = input.Split(new char[] { ' ', '.' });
            var count = Array.FindAll(arr, s => s.Equals(searchText.Trim())).Length;
            Console.WriteLine(count);
        }
    }
}
