using System;

namespace _03_Roots
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            d = (b * b)-4*a*c;

            if (d>=0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write(x2);
                Console.Write(x1);
            }


        }
    }
}
