using System;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {

            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
           
            int y2 = Convert.ToInt32(Console.ReadLine());


            Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            Console.WriteLine(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)));

                






        }
    }
}
