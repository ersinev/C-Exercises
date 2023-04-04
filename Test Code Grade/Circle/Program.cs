using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, per_cir, area;
            double pi = Math.PI;
            r = Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * pi * r;
            area = pi * Math.Pow(r, 2);
            Console.WriteLine(Math.Round(per_cir,1));
            Console.WriteLine(Math.Round(area,1));
            
            











        }
    }
}
