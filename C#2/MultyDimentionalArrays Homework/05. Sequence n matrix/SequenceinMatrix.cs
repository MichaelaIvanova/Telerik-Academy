using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_n_matrix
{
    class SequenceinMatrix
    {
        //We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
        //Write a program that finds the longest sequence of equal strings in the matrix.
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, m];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col<matrix.GetLength(1); col++)
               {
                   matrix[row, col] = Console.ReadLine();
              }
            }

           // string[,] matrix = new string[,] { { "ha", "fifi", "ho", "hi" }, 
                                              // { "fo", "ha", "hi", "xx" }, 
                                              // { "xxx", "ho", "ha", "xx" } };

            // check sequence

            int bestSequenceRows = 1;
            string bestStringSequenceRows = string.Empty;
            int counterSequenceRows = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                        counterSequenceRows++;
                        else
                            counterSequenceRows = 1;
                    if (counterSequenceRows > bestSequenceRows)
                    {
                        bestSequenceRows = counterSequenceRows;
                        bestStringSequenceRows = matrix[row, col];
                    }
                }
            }
            if (bestSequenceRows > 1)
                Console.WriteLine("Best sequence row is {0} times, and the element is {1}", counterSequenceRows, bestStringSequenceRows);
            else
                Console.WriteLine("No sequence in by rows/hozintally");

            int bestSequenceCols = 1;
            string bestStringSequenceCols = string.Empty;
            int counterSequenceCols = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                        counterSequenceCols++;
                    else
                        counterSequenceCols = 1;
                    if (counterSequenceCols > bestSequenceCols)
                    {
                        bestSequenceCols = counterSequenceCols;
                        bestStringSequenceCols = matrix[row, col];
                    }
                }
            }
            if (bestSequenceCols > 1)
                Console.WriteLine("Best sequence row is {0} times, and the element is \"{1}\"", counterSequenceCols, bestStringSequenceCols);
            else
                Console.WriteLine("No sequence in cols/vertically");

            int bestSequenceLeftDiagonal = 1;
            string bestStringSequenceLefDiagonal = string.Empty;
            int counterSequenceLeftDiagonal = 1;


            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                        counterSequenceLeftDiagonal++;
                    else
                        counterSequenceLeftDiagonal = 1;
                    if (counterSequenceLeftDiagonal > bestSequenceLeftDiagonal)
                    {
                        bestSequenceLeftDiagonal = counterSequenceLeftDiagonal;
                        bestStringSequenceLefDiagonal = matrix[row, col];
                    }
                }
            
            if (bestSequenceLeftDiagonal > 1)
                Console.WriteLine("Best sequence left diagonal is {0} times, and the element is \"{1}\"", bestSequenceLeftDiagonal, bestStringSequenceLefDiagonal);
            else
                Console.WriteLine("No sequence in left diagonal");

            int bestSequenceRightDiagonal = 1;
            string bestStringSequenceRightDiagonal = string.Empty;
            int counterSequenceRightDiagonal = 1;


            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                        counterSequenceRightDiagonal++;
                    else
                        counterSequenceRightDiagonal = 1;
                    if (counterSequenceRightDiagonal > bestSequenceRightDiagonal)
                    {
                        bestSequenceRightDiagonal = counterSequenceRightDiagonal;
                        bestStringSequenceRightDiagonal = matrix[row, col];
                    }
                }
            
            if (bestSequenceRightDiagonal > 1)
                Console.WriteLine("Best sequence left diagonal is {0} times, and the element is \"{1}\"", bestSequenceRightDiagonal, bestStringSequenceRightDiagonal);
            else
                Console.WriteLine("No sequence in right diagonal");

            int[] sequence = new int[4] { bestSequenceRows, bestSequenceCols, bestSequenceLeftDiagonal, bestSequenceRightDiagonal };
            string[] element = new string[4] {bestStringSequenceRows, bestStringSequenceCols, bestStringSequenceLefDiagonal, bestStringSequenceRightDiagonal };
            int maxSequence = sequence.Max();
            int maxSequenceIndex = sequence.ToList().IndexOf(maxSequence);
            string maxSequenceElement = element[maxSequenceIndex];

            Console.WriteLine("The best sequence in the matrix countains {0} element of the type \"{1}\"", maxSequence, maxSequenceElement);

        }
    }
}
