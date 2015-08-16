using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class Program
    {
        //Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
        static void Main(string[] args)
        {
            Console.WriteLine("enter text");
            string text = Console.ReadLine();
            Console.WriteLine("enter string to check");
            string check = Console.ReadLine();

            int countSubstring = text.Select((c, i) => text.Substring(i)).Count(sub => sub.StartsWith(check));
            Console.WriteLine("{0} appears {1} times", check, countSubstring);

        }
    }
}
