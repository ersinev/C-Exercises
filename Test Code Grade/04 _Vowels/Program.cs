using System;

namespace _04__Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = Console.ReadLine();
            int i, len, vowel_count, cons_count;
            
            vowel_count = 0;
            cons_count = 0;
            
            len = myStr.Length;
            
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel_count++;
                   
                }
            }

            Console.WriteLine(vowel_count);
        }
    }
}
