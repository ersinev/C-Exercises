using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight(kg)");
            double w1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height(m)");
            double h1 = Convert.ToDouble(Console.ReadLine());
            double result = Convert.ToDouble(((w1 / Math.Pow(h1, 2))));
            Console.WriteLine(Math.Round(result, 4));











        }
    }
}
