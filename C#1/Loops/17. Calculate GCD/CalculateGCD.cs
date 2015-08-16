using System;

    class CalculateGCD
    {
        //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
        //Use the Euclidean algorithm (find it in Internet).
        static void Main()
        {
          
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int quotient = 0;
            int remainder = 1;
            while (remainder != 0)
            {
                remainder = a % b;
                quotient = a / b;
                a = b;
                b = remainder;
            }
            Console.WriteLine(a);

        }
    }

