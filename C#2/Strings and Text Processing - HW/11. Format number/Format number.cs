using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Format_number
{
    class Program
    {
        //Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
        //Format the output aligned right in 15 symbols.
        static void Main(string[] args)
        {
            int n = 123;
            //int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:D}", n);
            Console.WriteLine("{0,15:X}", n);
            Console.WriteLine("{0,15:P}", n);
            Console.WriteLine("{0,15:E}", n);
        }
    }
}
