using System;

namespace _04_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            string result = "false 1";
            for (int i = 1; i <= n; i++)
            {
                if (n != 2 || i == 1)
                {
                    if (i != 1 && n % i == 0 && n != i)
                    {
                        result = result + " " + i;
                        isPrime = false;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine(result + " " + n);
            }

        

    }
    }
}
