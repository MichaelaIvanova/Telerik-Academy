using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_digit
{
    class EnglishDigit
    {
        //Write a method that returns the last digit of given integer as an English word.
        static void Main(string[] args)
        {
            Console.WriteLine("enter integer:");
            string number = Console.ReadLine();
            string result = ReturnDigitAsWord(number);
            Console.WriteLine(result);

        }

        static string ReturnDigitAsWord (string number)
           {
            // ili number%10
               string numberStr = number.ToString();
               char[] digit = numberStr.ToCharArray();
               char lastDigit = digit[digit.Length - 1];
               string lastDigitWord = string.Empty;

               switch (lastDigit)
               {
                   case '0': lastDigitWord += "Zero";
                       break;
                   case '1': lastDigitWord +="One";
                       break;
                   case '2': lastDigitWord +="Two";
                       break;
                   case '3': lastDigitWord +="Three";
                       break;
                   case '4': lastDigitWord +="Four";
                       break;
                   case '5': lastDigitWord +="Five";
                       break;
                   case '6': lastDigitWord +="Six";
                       break;
                   case '7': lastDigitWord +="Seven";
                       break;
                   case '8': lastDigitWord +="Eight";
                       break;
                   case '9': lastDigitWord +="Nina";
                       break;
                   default: Console.WriteLine("Error"); break;

               }
               return lastDigitWord;

           }
    }
}
