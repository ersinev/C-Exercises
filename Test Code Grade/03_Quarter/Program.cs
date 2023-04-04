using System;

namespace _03_Quarter
{
    class Program
    {
        static void Main(string[] args)
        {
            string girilen = Console.ReadLine();
            string[] words = girilen.Split('/');
            
            int y = Convert.ToInt32(words[0]);
           
            

            if (y<= 3)
            {
                Console.WriteLine("1");
            }

           

            if (y>3 && y<=6)
            {
                Console.WriteLine("2");
            }


            if (y > 6 && y <= 9)
            {
                Console.WriteLine("3");
            }

           

            if (y>9 && y<=12 )
            {
                Console.WriteLine("4");
            }


           










        }








    }
}
