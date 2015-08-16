using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Workdays
{
    class Workdays
    {
        //Write a method that calculates the number of workdays between today and given date, passed as parameter.
       // Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("enter date to count working days form now");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            int periodNum = (int)(endDate - now).TotalDays + 1;// how many days from now + 1 to get the last day inclusive
            Console.WriteLine(periodNum);

            Console.WriteLine("enter dates of public holidays and when ready write END:");
            List<DateTime> holidaysPublic = new List<DateTime>();

            while (holidaysPublic.Count<= periodNum)
            {
               string input = Console.ReadLine();
               if (input == "END") break;

               DateTime holiFixed = DateTime.Parse(input);
               holidaysPublic.Add(holiFixed);
            }

            int workdays = 0;
            int holidays = 0;
            
            List<DateTime> dateBYdate = new List<DateTime>();

            for (int i = 1; i<=periodNum; i++)// from index 1 to skip today day
            {
                DateTime current = now.AddDays(i);
                dateBYdate.Add(current);

                string currentDay = current.DayOfWeek.ToString();
                switch (currentDay)
                {
                    case "Saturday": holidays++; break;
                    case "Sunday": holidays++; break;
                    default: workdays++; break;
                }

            }
             
            // print the two LISTS to compare visualy and see if there is a problem
            foreach (DateTime day in dateBYdate)
            {
                Console.WriteLine(day);
            }
            foreach (DateTime day in holidaysPublic)
            {
                Console.WriteLine(day);
            }


            //check if PUBLIC holyday

            int holidaysFixed = 0;

            foreach (DateTime date in holidaysPublic)
            {
                foreach (DateTime daT in dateBYdate)
                {
                    if (date.Day == daT.Day)//to get only da date withou hours
                        holidaysFixed++;
                }
            }
            Console.WriteLine(holidaysFixed);
            Console.WriteLine("work day are: {0} regular holydays are :{1} and fixed holiday in addion are: {2}", workdays, holidays, holidaysFixed);
        }
    }
}
