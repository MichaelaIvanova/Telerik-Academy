using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Order_words
{
    class Program
    {
        //Write a program that reads a list of words, 
        //separated by spaces and prints the list in an alphabetical order.
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');

            Array.Sort(words);//!!!!!!!!!!!
            Console.WriteLine("Your words in alphabetical order: ");
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
