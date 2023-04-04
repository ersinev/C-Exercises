using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Panagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            System.Console.WriteLine("Enter a string");
            string ip = System.Console.ReadLine();

            foreach (char c in alpha)
            {
                foreach (char l in ip.ToLower())
                {
                    if (c == l)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == 26)
                System.Console.WriteLine("true");
            else
                System.Console.WriteLine("false");
        }
    }
}
