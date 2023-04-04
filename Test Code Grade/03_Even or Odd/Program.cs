using System;

namespace _03_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, rem1;
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("even", num1);
            else
                Console.WriteLine("odd", num1);
        }
    }
}
