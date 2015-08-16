using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Reverse_sentence
{
    class Program
    {
        //Write a program that reverses the words in given sentence.
        //Delphi not and PHP, not C++ not is C#! reversed result
        // origina 
        static void Main(string[] args)
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            char sign = input[input.Length-1];

            //Console.WriteLine(sign);
            string textOnly = input.Substring(0, input.Length - 2);
            string[] wordsOnly = textOnly.Split(new char[] { ' ', ',' });//moje da dobawim i o6te ; ili :: i tn
            List<string> wordsAll = wordsOnly.ToList();
            wordsAll.Reverse();

            wordsAll.Insert(4, ",");
            wordsAll.Add(sign.ToString());// moje samo stringove da adva            
            Console.WriteLine(string.Join(" ", wordsAll)); 
 
              

        }
    }
}
