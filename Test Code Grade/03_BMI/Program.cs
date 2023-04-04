using System;

namespace _03_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            float bmi;
            int kg = Convert.ToInt32(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float kare = height * height;
            bmi = kg /kare;
            
            if (bmi<18.5)
            {
                Console.WriteLine("underweight");
            }
            if (bmi>=18.5 && bmi<=24.9)
            {
                Console.WriteLine("normal");
            }

            if (bmi>=25 && bmi<=29.9)
            {
                Console.WriteLine("overweight");
            }

            if (bmi>=30 && bmi<=34.9)
            {
                Console.WriteLine("obese");
            }

            if (bmi>35)
            {
                Console.WriteLine("extremely obese");
            }

        }
    }
}
