using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_HW
{
    class SayHello
    {
        //Write a method that asks the user for his name and prints “Hello, <name>”
        //Write a program to test this method.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            PrintSayHello(name);
        }
        static void PrintSayHello(string name)
        {          
            Console.WriteLine("Hello " + name);
        }
    }
}
