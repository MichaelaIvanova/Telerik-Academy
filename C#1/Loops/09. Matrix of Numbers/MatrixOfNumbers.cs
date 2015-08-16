using System;

    class MatrixOfNumbers
    {
        //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
        static void Main()
        {
            Console.WriteLine("Enter an integer in the range (1 <= n <= 20):");
            int n = int.Parse(Console.ReadLine());
            int countCol = 1;

            for ( int i = 1; i <= n; i++)
            {

                for (int j = i; j <= n + n; j++) //!!!!!! to be full
                {
                    if (countCol <= n) // how many times the loop has been executed, n, the matrix size 
                    {
                        Console.Write("{0} ", j);
                        countCol++;
                    }

                }
                Console.WriteLine();
                countCol = 1;
            }


        }
    }

