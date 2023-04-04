using System;

namespace Celcius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            celsius = Math.Round(celsius, 2);
            Console.WriteLine(celsius);












        }
    }
}
