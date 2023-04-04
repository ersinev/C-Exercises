using System;
using System.Text.RegularExpressions;
namespace _05_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum7Chars = new Regex(@".{7,}");

            var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum7Chars.IsMatch(input);
            
            if (isValidated)
            {
                Console.WriteLine("strong");
            }

            else
            {
                Console.WriteLine("weak");
            }
        }
    }
}
