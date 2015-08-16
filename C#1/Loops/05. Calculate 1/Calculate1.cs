using System;

    class Calculate1
    {
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n
// Use only one loop. Print the result with 5 digits after the decimal point.
        static void Main()
        {
            Console.WriteLine("Enter integer n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer x:");
            int x = int.Parse(Console.ReadLine());
            double sum = 1;
            int factorial = 1;

            for (int i = 1; i <= n; i++)// allways starts from 1
            {
                factorial *= i;
                sum += (factorial / Math.Pow(x, i));
            }
            Console.WriteLine("{0:F5}", sum);

        }
    }

