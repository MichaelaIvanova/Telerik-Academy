using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Words_count
{
    class Program
    {
//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
        static void Main(string[] args)
        {
            string input = " ab aba aaaaa c wwh aihau,  ajh ut  uy u ua aiiiiiii aiiiiii a a a a a a.";
            string[] word = input.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            //List<string> counted = new List<string>();

            Dictionary<string, int> counts = word.GroupBy(x => x)
                                                   .ToDictionary(g => g.Key,
                                                    g => g.Count());
           foreach( KeyValuePair<string, int> kvp in counts )
           {
               Console.WriteLine("Key = {0}, Value = {1}",
                         kvp.Key, kvp.Value);
           }
        }
    }
}
