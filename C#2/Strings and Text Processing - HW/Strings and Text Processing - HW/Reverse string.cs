using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Text_Processing___HW
{
    class Program
    {
        //Write a program that reads a string, reverses it and prints the result at the console.
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
           // Console.WriteLine(text);
            char[] textCH = text.ToCharArray();
            char[] reversed = textCH.Reverse().ToArray();
            Console.WriteLine(string.Join("", reversed));

        }
    }
}
