using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        //Write a program to check if in a given expression the brackets are put correctly.
        //Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
        static void Main(string[] args)
        {
            Console.WriteLine("enter expression with brackets");
            string expression = Console.ReadLine();
            bool result = IsCorrect(expression);
            Console.WriteLine("is expression correct?:{0}", result);
        }
        static bool IsCorrect(string expression)
        {
            bool isCorrect = true;

            int countLeftBrackets = expression.Count(a => a == '(');
            int countRightBrackets = expression.Count(b => b == ')');
            int indexFirstLeftBracket = expression.IndexOf((expression.First(x => x == '(')));
            int indexFirstRightBracket = expression.IndexOf((expression.First(x => x == ')')));

            if (countLeftBrackets != countRightBrackets || indexFirstLeftBracket > indexFirstRightBracket)
            {
                isCorrect = false;
            }

            return isCorrect;
            
        }
    }
}
