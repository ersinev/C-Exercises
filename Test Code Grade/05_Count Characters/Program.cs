using System;

namespace _05_Count_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, len, vowel, cons;

            str = Console.ReadLine();

            vowel = 0;
            cons = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U' || str[i] == 'y' || str[i] == 'Y')
                {
                    vowel++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    cons++;
                }
            }

            int other = len - (vowel + cons);
            Console.Write("\nvowels: {0}\n", vowel);
            Console.Write("consonants: {0}\n\n", cons);
            Console.WriteLine("\nother: {0}\n",other);

        }
    }
}
