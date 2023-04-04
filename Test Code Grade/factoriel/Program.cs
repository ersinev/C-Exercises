using System;
using System.IO;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("ersin.txt");

            Console.WriteLine("Hello world");
            stream.WriteLine("Omg, some text in a file, A-MA-ZING");











            stream.Close();
        }
    }
}
