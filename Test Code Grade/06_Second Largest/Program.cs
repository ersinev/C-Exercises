using System;

namespace _06_Second_Largest
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int[] array = Array.ConvertAll(input, s => Int32.Parse(s));

            int Max1 = array[0];
            int Max2 = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                Max2 = Math.Max(Max1, array[i]);
                Max1 = Max2;
            }
            int previousSecondLargest = 0;
            int secondLargest = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                secondLargest = Math.Max(previousSecondLargest, array[i]);
                if (secondLargest != Max2)
                {
                    previousSecondLargest = secondLargest;
                }
            }
            Console.WriteLine(previousSecondLargest);

        }
    }
    
}
