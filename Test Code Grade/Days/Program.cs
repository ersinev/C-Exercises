using System;

namespace Days
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days");
            int nbdays =Convert.ToInt32(Console.ReadLine());
            int year = 365;
            int week = 7;
            int yearleft = nbdays / year;
            int totalDayAfterYear = nbdays % year;
            int yearWeek = totalDayAfterYear / week;
            int totalDayAfterWeek = totalDayAfterYear % week;

            Console.WriteLine(yearleft + " year(s)");
            Console.WriteLine(yearWeek + " week(s)");
            Console.WriteLine(totalDayAfterWeek + " day(s)");
            
    











        }
    }
}
