using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Range_Exceptions
{
    class MainSystemExceptions
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>("Number must be in range [1..100]", 1, 100);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);

            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>("Date must be in range [1.1.1980] - [31.12.2013]", startDate, endDate);
            }
        }
    }
}
