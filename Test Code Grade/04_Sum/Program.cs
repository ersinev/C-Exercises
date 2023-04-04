using System;

namespace _04_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (number % 2 == 0)
            {

                number = number + 1;
            }
                for (int i = number; i <= number2; i+=2)
                {
                sum = sum + i;
               

                }
            Console.WriteLine(sum);



        }
    }
}
