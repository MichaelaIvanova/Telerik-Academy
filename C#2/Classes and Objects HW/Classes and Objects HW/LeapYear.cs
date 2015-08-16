using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_HW
{
    class LeapYear
    {
        //Write a program that reads a year from the console and checks whether it is a leap one.
        static void Main(string[] args)
        {
            Console.Write("enter a year:");
            int n = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(n);
            Console.WriteLine("{0} year is leap: {1}", n, isLeap);

        }
    }
}
