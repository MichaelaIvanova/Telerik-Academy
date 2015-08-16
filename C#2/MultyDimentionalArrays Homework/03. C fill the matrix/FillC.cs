using System;

    class FillC
    {
//7	11	14	16
//4	8	12	15
//2	5	9	13
//1	3	6	10
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;


            for (int i = 0; i <= n - 1; i++)
                for (int j = 0; j <= i; j++) matrix[n - i + j - 1, j] = counter++;

            for (int i = n - 2; i >= 0; i--)
                for (int j = i; j >= 0; j--) matrix[i - j, n - j - 1] = counter++;


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }

