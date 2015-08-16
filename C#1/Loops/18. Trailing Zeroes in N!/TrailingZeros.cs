using System;

using System.Numerics;

    class TrailingZeros
    {
        //Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
        //Your program should work well for very big numbers, e.g. n=100000.
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i=1; i<=n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

            string factorialNew = factorial.ToString();
            char[] factorialChars = factorialNew.ToCharArray();

            int zeros = 0;
            int count = 0;
            for (int i = factorialChars.Length-1; i>=0; i--)
            {
                char zero = factorialChars[i];
                bool lastZero = (zero == '0');
              if (lastZero)
              {
                  count++;
              }
              else
              {
                  break;
              }
            }

            Console.WriteLine(count);


            

        }


    }

