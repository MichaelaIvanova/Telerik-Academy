using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Letters_count
{
    class Program
    {
        //Write a program that reads a string from the console and prints 
        //all different letters in the string along with information how many times each letter is found.
        static void Main(string[] args)
        {
            string input = "abbfgsisjsutuhuyuuhshushushuAAAAhuh123";
            List<string> counted = new List<string>();

            foreach( char symbol in input)
            {
                if (char.IsLetter(symbol))
                {
                    int counter = input.Count(s => s == symbol);
                    counted.Add(symbol + " " + counter);
                   // Console.WriteLine(symbol + " " + counter);
                }
            }
            List<string> noDupes = counted.Distinct().ToList();// mahan dublicatite
            Console.WriteLine(string.Join("\n", noDupes));
        }
    }
}
