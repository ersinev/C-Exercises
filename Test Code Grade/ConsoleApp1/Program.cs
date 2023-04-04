using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fruit = Console.ReadLine();
            //if (fruit== "orange")
            //{
            //    Console.WriteLine("MMMHHHHH");
            //}
            //else if (fruit== "apple")
            //{
            //    Console.WriteLine("NICEE");
            //}

            //else
            //{
            //    Console.WriteLine("i dont recognise this fruit");
            //}

            //switch (fruit)
            //{
            //    case "orange":
            //        Console.WriteLine("MMMHHHHH");
            //        break;
            //    case "apple":
            //        Console.WriteLine("NICEE");
            //        break;

            //    default:

            //        Console.WriteLine("i dont recognise this fruit");
            //        break;

            //int number = Convert.ToInt32(Console.ReadLine());
            //int maxNumber = 10;
            //for (int x = 0; x <= maxNumber; x++)
            //{
            //    int result = x * number;
            //    Console.WriteLine($"{ number}*x ={result}");
            //}


            //while (step)
            //{

            //}



            //}



            //int number = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());




            //    for (int step = number; step <= number2; step++)
            //    {
            //        int remainder = step % 3;
            //        {
            //            Console.WriteLine(step);
            //        }
            //    }

            //for (int i = 1; i <=15; i++)
            //{
            //    int dvd3 = i % 3;
            //    int dvd5 = i % 5;

            //    if (dvd3==0)
            //    {
            //        Console.WriteLine("Fizz");

            //    }

            //    if(dvd5==0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }

            //    if(dvd3==0 && dvd5==0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }

            //}


            int money = Convert.ToInt32(Console.ReadLine());

            if (money==5)
            {
                Console.WriteLine("Here are the sausages");
            }

            else if (money>5)
            {
                Console.WriteLine("Here are the sausages, "+ (money - 5) +" euro back to you"   );
            }

            else if (money<5)
            {
                while (money<5 )
                {
                    Console.WriteLine("Give me more money this is not enough");
                }
            }

                
            
            

            

           
            


        }
    }
}
