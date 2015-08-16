using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Date_difference
{
    class Program
    {
        //Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
        static void Main(string[] args)
        {
            DateTime dateOne = DateTime.Parse(Console.ReadLine());
            DateTime dateTwo = DateTime.Parse(Console.ReadLine());

            int days = Math.Abs((dateOne - dateTwo).Days);
            Console.WriteLine(days);
        }
    }
}
