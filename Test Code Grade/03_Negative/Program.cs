using System;

namespace _03_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("negative");
            }

            if (n > 0)
            {
                Console.WriteLine("positive");
            }

            if (n == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}
