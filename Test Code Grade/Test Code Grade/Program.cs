using System;

namespace Test_Code_Grade
{
    class Program
    { /*Read the name and surname of a person and say 'Hello' to them!

        Test case examples

            input
            Elke
            Boonen
            output
             Hello Elke Boonen!*/
        static void Main(string[] args)
        {

            Console.WriteLine("type your name");
            string name = Console.ReadLine();
            Console.WriteLine("type your age");
            int age = Convert.ToInt32(Console.ReadLine());
            int year = DateTime.Now.Year - age;
            Console.WriteLine(name+ " was born in " + year + "!");
        }
    }
}
