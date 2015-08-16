using System;

    class MaximalSumN
    {

 // Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];

            for ( int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col<matrix.GetLength(1); col++)
                {
                    matrix[col,row] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[col, row]);

                }
                Console.WriteLine();
            }



            int maxSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2]
            + matrix[1, 0] + matrix[1, 1] + matrix[1, 2]
            + matrix[2, 0] + matrix[2, 1] + matrix[2, 2];

            int bestrow = 0;
            int bestcol = 0;
            Console.WriteLine(maxSum);

            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                   int sum = matrix[row,col] + matrix[row,col+1] + matrix[row,col+2]
                       + matrix [row+1,col]+matrix[row+1,col+1]+matrix[row+1,col+2]
                       + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if(sum>maxSum)
                    {
                        maxSum = sum;
                        bestrow = row;
                        bestcol = col;
                    }
                }
            }
            Console.WriteLine("the max sum is {0}",maxSum);
            Console.WriteLine("the first member is {0}", bestrow, bestcol);

        }
    }

