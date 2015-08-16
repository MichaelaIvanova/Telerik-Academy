using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Forbidden_words
{
    class Program
    {
        
       //We are given a string containing a list of forbidden words and a text containing some of these words.
       //Write a program that replaces the forbidden words with asterisks
        static void Main(string[] args)
        {
            string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = new string[] { "PHP", "CLR", "Microsoft" };
            string[] inputSplited= input.Split(new char[]{'.',' '});
           // Console.WriteLine(string.Join("&", inputSplited));
           // List<string> withouForbitted= new List<string>();

            foreach (string word in forbiddenWords )
            {
                for (int i = 0; i<inputSplited.Length;i++)
                {
                    input = input.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(input);

        }

    }
}
