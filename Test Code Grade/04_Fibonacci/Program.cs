using System;

namespace _04_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int sumNew = 1;
            int result;
            int sum = 0;
            int last;
            while (i<=input)
            {
                if (i==0)
                {
                    sumNew = 0;
                    i++;
                }

                else if (i>0 && i<2)
                {
                    sumNew = 1;
                    i++;
                }

                else
                {
                    last = sum + sumNew;
                    sum = sumNew;
                    sumNew = last;
                    i++;
                }

                Console.WriteLine(sumNew+"");
            }
        
        
        
        }   
    }
}
