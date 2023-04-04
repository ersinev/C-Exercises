using System;
using System.IO;
namespace files1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = Path.Combine("@C:/Users/ersin/source/repos/Test Code Grade\files1");

            //StreamWriter stream = File.CreateText("ersin.txt");

            //StreamWriter stream = File.CreateText("files1.txt");
            //stream.WriteLine("This is a test file");

            //string path =Path.Combine(@"c:\Users", "files1.txt");
            //string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //path = Path.Combine(folder, "file.txt");

            //StreamWriter stream = File.CreateText(path);


            //ARRAYS;

            //int[] grades = new int[5];
            //grades[0] = 10;
            //grades[1] = 4;
            //grades[2] = 3;
            //grades[3] = 4;
            //grades[4] = 8;
            //grades[5] = 9;
            //grades[6] = 8;
            //grades[7] = 7;
            //grades[8] = 6;
            //grades[9] = 5;

            //Console.WriteLine(grades[0]);
            //Console.WriteLine(grades[1]);            

            ////or
            ////int[] grades2 ={10, 4, 3, 4, 8, 9, 8, 7, 6, 5};
            ///

            // string[] names = { "harry potter", "Ron weasley", "hermonie", "voldemort" };


            //string[] characters = new string[4];
            //characters[0] = "harry potter";
            //characters[1] = "ron weasley";

            //for (int index = 0; index < names.Length; index++)
            //{
            //    Console.WriteLine(names[index]);
            //}

            //int number = 0;
            //while (number<names.Length)
            //{
            //    Console.WriteLine(names[number]);
            //    number++;
            //}

            //foreach (string character in names)
            //{

            //}


            //////////////
            //string student1 = Console.ReadLine();
            //string student2 = Console.ReadLine();
            //string student3 = Console.ReadLine();
            //string[] students = new string[3];
            //students[0] = student1;
            //students[1] = student2;
            //students[2] = student3;

            //input of data in array
            ////for (int i = 0; i < students.Length; i++)
            //{
            //    students[i] = Console.ReadLine();
            //}

            //// output
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine(students[0]);
            //Console.WriteLine(students[1]);
            //Console.WriteLine(students[2]);



            //int[] students = new int[5];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.ReadLine(i);

            //}

            //int[,] grades = new int[2, 4];

            ////student1
            //grades[0, 0] = 5;
            //grades[0, 1] = 10;
            //grades[0, 2] = 8;
            //grades[0, 3] = 5;
            ////student2
            //grades[1, 0] = 0;
            //grades[1, 1] = 10;
            //grades[1, 2] = 5;
            //grades[1, 3] = 7;

            //for (int student = 0; student < grades.GetLength(0); student++)
            //{
            //    Console.WriteLine("Student" + student);
            //    for (int gradesIndex = 0; gradesIndex < grades.GetLength(1); gradesIndex++)
            //    {
            //        Console.WriteLine("Grade" + gradesIndex);
            //    }

            //}
            int numberofstudents = Convert.ToInt32(Console.ReadLine());
            int numberoftests = Convert.ToInt32(Console.ReadLine());
            double[,] grades = new double[numberofstudents, numberoftests];

            //for (int studentindex = 0; studentindex < grades.GetLength(0); studentindex++)
            //{
            //    for (int testindex = 0; testindex < grades.GetLength(1); testindex++)
            //    {
            //        Console.WriteLine($"Student {studentindex} test{ testindex}");
            //        grades[studentindex, testindex] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}


            grades[0, 0] = 5;
            grades[0, 1] = 10;
            






















        }
    }
}
