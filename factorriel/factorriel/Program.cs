using System;

namespace factorriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >0 ; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(+fact);
            
        }
    }
}
