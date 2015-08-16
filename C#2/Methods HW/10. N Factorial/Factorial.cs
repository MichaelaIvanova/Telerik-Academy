using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        //Write a program to calculate n! for each n in the range [1..100].
        //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i<input.Length; i++)
            {
                input[i] = i+1;
            }
            Console.WriteLine(string.Join(",", input));

            BigInteger[] inputFactorial = FactorialNums(input);
            Console.WriteLine(string.Join(",", inputFactorial));

        }
        static BigInteger [] FactorialNums (int[] input)
        {
            BigInteger factorial = 1;
            BigInteger[] factorialNums = new BigInteger[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j <= input[i]; j++)
                {
                    factorial *= j;
                }
                factorialNums[i] = factorial;
                factorial = 1;
            }

            return factorialNums;

        }



    }
}

//       static ulong [] (int[] num)
//              {
//                  ulong resultFactorial = 1;
//                  ulong [] numbersFactorail = new ulong[num.Length];

//                  for(int i = 1; i <= num.Length; i++)
//                     {
//                  resultFactorial = resultFactorial* i;

//                    }


//              return numbersFactorail;

//                }
//}
//}
