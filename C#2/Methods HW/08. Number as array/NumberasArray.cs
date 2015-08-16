using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.Number_as_array
{
    class NumberasArray
    {
        //Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
        //Each of the numbers that will be added could have up to 10 000 digits.
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first integer array 1:");
                BigInteger n = BigInteger.Parse(Console.ReadLine());
                char[] number1 = n.ToString().ToCharArray();

            Console.WriteLine("enter the second integer array 2:");
            BigInteger m = BigInteger.Parse(Console.ReadLine());
                char[] number2 = m.ToString().ToCharArray();
                
                if (number1.Length > 10000 || number2.Length > 10000)
                { 
                    Console.WriteLine("error");
                    return;
                }

                BigInteger result = SumReversed(number1, number2);
                Console.WriteLine("The sum of the two integers represented in 2 reversed arrays is {0}", result);
             
        }
        static BigInteger SumReversed(char[] numberOne, char [] numberTwo)
        {
            Array.Reverse(numberOne);
            int[] digitsONE = Array.ConvertAll(numberOne, c => (int)Char.GetNumericValue(c));
            string numberOne1 = string.Join("", digitsONE);
            BigInteger numberOneFinal = int.Parse(numberOne1);

            Array.Reverse(numberTwo);
            int[] digitsTWO = Array.ConvertAll(numberOne, c => (int)Char.GetNumericValue(c));
            string numberTwo2 = string.Join("", digitsTWO);
            BigInteger numberTwoFinal = int.Parse(numberTwo2);

            BigInteger sum = numberOneFinal + numberTwoFinal;

            return sum;
        }
    }
}
