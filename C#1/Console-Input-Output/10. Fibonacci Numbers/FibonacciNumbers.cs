using System;

    class FibonacciNumbers
    {
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
        static void Main()
        {
            Console.WriteLine("Enter the number of numbers: ");
            int n = int.Parse(Console.ReadLine());
            long a0 = 0;
            long a1 = 1;

            Console.Write("{0} ,{1}", a0, a1);
            for (int i = 2; i < n; i++)
            {
                long a2 = a0 + a1;
                Console.Write(" , {0}", a2);
                a0 = a1;
                a1 = a2;


            }
            Console.WriteLine();
        }
    }

