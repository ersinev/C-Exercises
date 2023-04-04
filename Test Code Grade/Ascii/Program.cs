using System;

namespace Ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());

            int resultch = Convert.ToInt32(ch) - 1;
            
            Console.WriteLine(Convert.ToChar(resultch));








        }
    }
}
