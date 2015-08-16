using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Date_in_Bulgarian
{
    class Program
    {
        //Write a program that reads a date and time given in the 
        //format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
        static void Main(string[] args)
        {
            string date = "1.3.2015 16:20:35";
            string[] split = date.Split(new char[] { '.', ' ',':' });
            int[] splited = split.Select(int.Parse).ToArray();
            DateTime dateNow = new DateTime (splited[2], splited[1], splited[0], splited[3], splited[4], splited[5]);
            Console.WriteLine(dateNow);

            DateTime dateAfter = dateNow.AddHours(6).AddMinutes(30);
            Console.WriteLine(dateAfter);
            //string dayOfWeek = culture.DateTimeFormat.GetDayName(dateNow.DayOfWeek);
            
            string dayofWeek = dateNow.DayOfWeek.ToString();
            Console.WriteLine(dayofWeek);

        }
    }
}
