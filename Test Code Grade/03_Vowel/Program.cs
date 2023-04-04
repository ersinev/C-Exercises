using System;

namespace _03_Vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = Convert.ToChar(Console.ReadLine());




            if (x == 'a' || x== 'e' || x=='i' || x=='o' || x=='u' )
            {
                Console.WriteLine("vowel");

            }

            else
            {
               Console.WriteLine("");
            }

            if (char.IsNumber(x))
            {
                Console.WriteLine("number");
            }
            else
            {
                Console.WriteLine("consonant");
            }











        }
    }
}

