using System;
using System.Text.RegularExpressions;


namespace _05_Punctuation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ant = Console.ReadLine();

            //Regex regex = new Regex("[!]+");
            //var news = regex.Replace(ant, "!");
            //Regex regex2 = new Regex("[?]+");
            //news = regex2.Replace(news, "?");
            //Regex regex3 = new Regex("[.]+");
            //news = regex3.Replace(news, ".");
            //Regex regex4 = new Regex("[:]+");
            //news = regex4.Replace(news, ":");
            //Regex regex5 = new Regex("[;]+");
            //news = regex5.Replace(news, ";");
            //Regex regex6 = new Regex("[,]+");
            //news = regex6.Replace(news, ",");
            //Regex regex7 = new Regex("[']+");
            //news = regex7.Replace(news, "'");

            //Regex regex9 = new Regex("[-]+");
            //news = regex9.Replace(news, "-");
            //Regex regex10 = new Regex("[—]+");
            //news = regex10.Replace(news, "—");
            //Regex regex11 = new Regex("[/]+");
            //news = regex11.Replace(news, "/");
            //Regex regex12 = new Regex("[()]+");
            //news = regex12.Replace(news, "()");
            //Regex regex13 = new Regex("[[]]+");
            //news = regex13.Replace(news, "[]");
            //Regex regex14 = new Regex("[...]+");
            //news = regex14.Replace(news, "...");
            //Regex regex15 = new Regex("[*]+");
            //news = regex15.Replace(news, "*");

            //Console.WriteLine(news);



            string ant = Console.ReadLine();
            var c = Regex.Matches(ant, @"[^\w\s]");
            foreach (var item in c)
            {
                
                ant = Regex.Replace(ant, @"[" + item.ToString() + @"]+", item.ToString());
            }
            Console.WriteLine(ant);

            Console.ReadLine();

        }
    }
}
