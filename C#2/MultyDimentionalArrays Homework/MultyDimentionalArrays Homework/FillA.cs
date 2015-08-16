using System;

    class FillA
    {

        //1	5	9	13
        //2	6	10	14
        //3	7	11	15
        //4	8	12	16
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
            
            for ( int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col<matrix.GetLength(1); col++)
                {
                    matrix[col,row] = counter++;
                    
                }
            }

            Console.WriteLine("The matrix is as follows:");

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

