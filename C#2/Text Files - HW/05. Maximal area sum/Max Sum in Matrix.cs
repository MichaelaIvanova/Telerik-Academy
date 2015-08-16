using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Maximal_area_sum
{
    class Program
    {
        //Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader(@"matrix.txt"))
            {
              // need to get line number 1 to end and plit to numbers;

                string line = reader.ReadLine();
                //int counterLines = 1;
                List<string[]> str = new List<string[]>();

                while(line!=null)
                {
                    string[] splitedLine = line.Split(' ').ToArray();
                    
                    str.Add(splitedLine);
                    //Console.WriteLine("hhhh");
                    line = reader.ReadLine();
                }
                str.RemoveAt(0); //mahame go za6toto tyka sani dannite za razmera a ne samata maatrixa
                
                foreach(var s in str)
                {
                    
                    Console.WriteLine(string.Join(" $ ", s));
                }

                int lenght = str[0].Length;
                Console.WriteLine(lenght);

                string[,] matrix = CreateRectangularArray(str);// super!
                
                //proverqvame
                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(" {0} ", matrix[col, row]);

                    }
                    Console.WriteLine();
                }
                // check sum 2x2
                int maxSum =int.Parse( matrix[0, 0] )+ int.Parse(matrix[0, 1])
                             + int.Parse(matrix[1, 0]) + int.Parse(matrix[1, 1]);
                int bestrow = 0;
                int bestcol = 0;
                Console.WriteLine(maxSum);

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        int sum =int.Parse( matrix[row, col]) + int.Parse(matrix[row, col + 1])
                            + int.Parse(matrix[row + 1, col]) + int.Parse(matrix[row + 1, col + 1]);
                           

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            bestrow = row;
                            bestcol = col;
                        }
                    }
                }
                Console.WriteLine("the max sum is {0}", maxSum);
                Console.WriteLine("the first member is {0}", bestrow, bestcol);
                
 
            }

        }
        static T[,] CreateRectangularArray<T>(IList<T[]> arrays)
        {
            // TODO: Validation and special-casing for arrays.Count == 0
            int minorLength = arrays[0].Length;
            T[,] ret = new T[arrays.Count, minorLength];
            for (int i = 0; i < arrays.Count; i++)
            {
                var array = arrays[i];
                if (array.Length != minorLength)
                {
                    throw new ArgumentException
                        ("All arrays must be the same length");
                }
                for (int j = 0; j < minorLength; j++)
                {
                    ret[i, j] = array[j];
                }
            }
            return ret;
        }

    }
}
