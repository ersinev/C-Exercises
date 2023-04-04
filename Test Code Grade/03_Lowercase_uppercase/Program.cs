using System;

namespace _03_Lowercase_uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = Convert.ToChar(Console.ReadLine());
            char.IsUpper(letter);

            if (char.IsUpper(letter))
            {
                Console.WriteLine("uppercase");
            }
            else
            {
                Console.WriteLine("lowercase");
            }
        }
    }
}
