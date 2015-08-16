using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class ReverseNumber
    {
        //Write a method that reverses the digits of given decimal number.
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("enter a decimal number:");
            decimal n = decimal.Parse(Console.ReadLine());

            string result = ReverseDecimal(n);
            Console.WriteLine(result);
          
        }
        static string ReverseDecimal(decimal n)
        {
            string number = n.ToString();
            char[] elements = number.ToCharArray();
            Array.Reverse(elements);
            string result = new string(elements);
            return result;
        }
    }
}
