using System;

    class CatalanNumbers
    {
        //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). formula: (2n)!/(n+1)!*n!
        static void Main()
        {
            Console.WriteLine("Enter an integer in the range (0 <= n <= 100):");
            int n = int.Parse(Console.ReadLine());
            long Factorial2N = 1; // obligatory LONG! else - overlap
            long FactorialN = 1;
            long FacturialNPlus1 = 1;
            if (n <0 || n >= 101)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            for (int i = 1; i <= 2 * n; i++) // because we have first 2n
            {
                Factorial2N *= i;
                if (i <= n)
                {
                    FactorialN *= i;
                }
            }
            for (int i = 1; i <= n + 1; i++) // because we have n+1
            {
                FacturialNPlus1 *= i;
            }
            Console.WriteLine("{0}", Factorial2N / (FactorialN *
            FacturialNPlus1));
        }
    }