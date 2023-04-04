using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _06_Find_the_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // Split on one or more non-digit characters.
            string[] numbers = Regex.Split(input, @"\D+");
            Array.Sort(numbers);
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    
                    int i = int.Parse(value);
                    
                    Console.Write(i);
                    
                }
            }
        }
    }
}
