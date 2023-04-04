using System;

namespace _04_FloydsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int row = 1;
            int column = 1;
            int x = 1;
            for (row = 1; row <=input; row++)
            {
                for (column = 1; column <= row; column++)
                {
                    Console.WriteLine($"{x} ");
                    x += 1;
                }

                Console.WriteLine();
            }




        }
    }
}
