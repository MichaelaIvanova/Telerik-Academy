using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix<T>
        where T : IComparable<T>
    {
        //Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

        //private fields
        private readonly T[,] matrix = null;
        private uint rows;
        private uint cols;

        // public properties
        public uint Rows { get; private set; }
        public uint Cols { get; private set; }

        // public constructor
        public Matrix (uint rows, uint cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[this.Rows, this.Cols]; // nqmame property za6toto ne ni trqbva a samo initializi it;
        }
        //9. Matrix indexer
        //Implement an indexer this[row, col] to access the inner matrix cells.

        public T this[uint x, uint y]
        {
            get { return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }

        //// Plus / Minus Operator
        public Matrix<T> Plus (Matrix<T> first, Matrix<T> second )
        {
             if (!(first.Rows == second.Rows && first.Cols == second.Cols))
            throw new ArgumentException("Matrix size is not the same!");

             Matrix<T> result = new Matrix<T>(first.Rows, second.Cols);

             for (uint i = 0; i < result.Rows; i++)
                 for (uint j = 0; j < result.Cols; j++)
                     result[i, j] = (dynamic) first[i, j] + second[i, j];

            return result;
        }
        public Matrix<T> Minus(Matrix<T> first, Matrix<T> second)
        {
            if (!(first.Rows == second.Rows && first.Cols == second.Cols))
                throw new ArgumentException("Matrix size is not the same!");

            Matrix<T> result = new Matrix<T>(first.Rows, second.Cols);

            for (uint i = 0; i < result.Rows; i++)
                for (uint j = 0; j < result.Cols; j++)
                    result[i, j] = (dynamic)first[i, j] - second[i, j];

            return result;
        }
        public Matrix<T> Multiply(Matrix<T> first, Matrix<T> second)
        {
            if (!(first.Rows == second.Rows && first.Cols == second.Cols))
                throw new ArgumentException("Matrix size is not the same!");

            Matrix<T> result = new Matrix<T>(first.Rows, second.Cols);

            for (uint i = 0; i < result.Rows; i++)
                for (uint j = 0; j < result.Cols; j++)
                    for (uint k = 0;  k< result.Rows; k++)
                    result[i, j] = (dynamic)first[i, k]*second[k, j];

            return result;
        }
        //Implement the true operator (check for non-zero elements).

        public static bool operator true(Matrix<T> matrixOne)
        {
            bool result = false;
            for (uint r = 0; r < matrixOne.matrix.GetLength(0); r++)
            {
                for (uint c = 0; c < matrixOne.matrix.GetLength(1); c++)
                {
                    if ((dynamic)matrixOne[r, c] != 0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool operator false(Matrix<T> matrixOne)
        {
            bool result = true;
            for (uint r = 0; r < matrixOne.matrix.GetLength(0); r++)
            {
                for (uint c = 0; c < matrixOne.matrix.GetLength(1); c++)
                {
                    if ((dynamic)matrixOne[r, c] == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

    }
}
