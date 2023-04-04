using System;

namespace _03_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());

            double total = (a + b + c + d + e);
            double percentage = (total / 50) * 100;

            if (percentage<40)
            {
                Console.WriteLine("F");
            }

            if (percentage>=40 && percentage<60)
            {
                Console.WriteLine("E");
            }

            if (percentage>=60 && percentage<70)
            {
                Console.WriteLine("D");
            }

            if (percentage>=70 && percentage<80)
            {
                Console.WriteLine("C");
            }

            if (percentage>=80 && percentage<90)
            {
                Console.WriteLine("B");
            }

            if (percentage>=90)
            {
                Console.WriteLine("A");
            }




        }
    }
}
