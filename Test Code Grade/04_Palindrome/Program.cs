using System;

namespace _04_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;

            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");

            }
        }
    }
}
