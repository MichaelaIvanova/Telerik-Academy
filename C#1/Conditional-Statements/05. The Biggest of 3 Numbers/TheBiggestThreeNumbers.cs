using System;

    class TheBiggestThreeNumbers
    {
        // Write a program that finds the biggest of three numbers.
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            double c = int.Parse(Console.ReadLine());

            double y = Math.Max(a, b);
            double x = Math.Max(y, c);
            Console.WriteLine("The biggest number is {0}", x);


        }
    }

