using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_characters
{
    class Program
    {
        //Write a program that converts a string to a sequence of C# Unicode character literals.
        //Use format strings.
        //Hi!	\u0048\u0069\u0021
        static void Main(string[] args)
        {
         string input = "Hi!";
         char[] arr = input.ToCharArray();
         StringBuilder hexarray = new StringBuilder();
            foreach(char ch in arr)
            {
                hexarray.AppendFormat("\\u{0:X4}",(int)ch);

            }
            Console.WriteLine(hexarray);
        }
    }
}
