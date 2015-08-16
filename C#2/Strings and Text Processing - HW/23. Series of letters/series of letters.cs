using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Series_of_letters
{
    class Program
    {
        //Write a program that reads a string from the console and 
        //replaces all series of consecutive identical letters with a single one.
        static void Main(string[] args)
        {
            string input = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder grouped = new StringBuilder();
            
            grouped.Append(input[0]);

            for (int i = 1; i<input.Length-1; i++)
            {
                if (input[i] != input[i - 1])
                {
                    grouped.Append(input[i]);
                }
            }
            Console.WriteLine(grouped.ToString());

           // List<char> second = input.ToCharArray().ToList();
           // List<char> noDupes = second.Distinct().ToList();
          //  Console.WriteLine(string.Join("", noDupes));
        }
    }
}
