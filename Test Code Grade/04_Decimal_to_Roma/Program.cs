using System;

namespace _04_Decimal_to_Roma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numDec = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numRom = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string numToRom = "";
            for (int i = 0; i < numDec.Length; i++)
            {
                while (num>=numDec[i])
                {
                    numToRom = numToRom + numRom[i];
                    num = num - numDec[i];
                }
            }
            Console.WriteLine(numToRom);
        }
    }
}
