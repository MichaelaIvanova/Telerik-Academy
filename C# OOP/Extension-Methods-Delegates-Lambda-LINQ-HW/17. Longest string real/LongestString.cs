using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Longest_string_real
{
    class LongestString
    {
        //Write a program to return the string with maximum length from an array of strings.
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a", "abbggg", "we" };

            string result = arr.OrderByDescending(s => s.Length).First();
            Console.WriteLine(result);

        }

    }
}
