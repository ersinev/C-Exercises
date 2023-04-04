using System;

namespace _06_MostOccuring
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(Console.ReadLine());
            LeftShiftArray(n, m+4);
            Console.WriteLine(String.Join(" ", n));
        }

        public static void LeftShiftArray<T>(T[] arr, int shift)
        {
            shift = shift % arr.Length;
            T[] buffer = new T[shift];
            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);
        }

    }
}

