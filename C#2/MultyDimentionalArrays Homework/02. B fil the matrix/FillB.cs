using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.B_fil_the_matrix
{
    class FillB
    {
        //1	8	9	16
        //2	7	10	15
        //3	6	11	14
        //4	5	12	13



        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;


                for (int col = 0; col < n; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            matrix[col, row] = counter++;
                        }
                    }
                    else
                    {
                        for (int row = n-1; row >= 0; row--)
                        {
                            matrix[col, row] = counter++;
                        }

                    }

                }
                Console.WriteLine("The matrix is as follows:");

                for (int col = 0; col < n; col++)           //Printing
                {
                    for (int row = 0; row < n; row++)
                    {
                        Console.Write("{0, 4}", matrix[row, col]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
 

        }

    }

}
