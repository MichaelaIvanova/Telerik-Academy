using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_length
{
    class Program
    {
        //Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *
        //Print the result string into the console.
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text.Length > 20)
            {
                Console.WriteLine("Error must be less than 20 chars");
                return;
            }

            if (text.Length<20)
            {
               text =  text.PadRight(20, '*');
                Console.WriteLine(text);
            }


        }
    }
}
