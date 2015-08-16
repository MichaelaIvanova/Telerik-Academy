using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Day_of_week
{
    class DayOfWeek
    {
        //Write a program that prints to the console which day of the week is today.
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;           
            string day = now.DayOfWeek.ToString();
            Console.WriteLine(day);
           
        }
    }
}
