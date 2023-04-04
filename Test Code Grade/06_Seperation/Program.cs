using System;

namespace _06_Seperation
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(s[i]);
            }
            Console.WriteLine(n);
            foreach (var item in arr)
            {
                int even = n % 2;
                if (even==0)
                {
                    Console.WriteLine(even);
                }
            }


        }

    }
}
    


