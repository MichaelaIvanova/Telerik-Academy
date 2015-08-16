using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class SortingArrays
    {
        //Write a method that return the maximal element in a portion of array of integers starting at given index.
        //Using it write another method that sorts an array in ascending / descending order.
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of integer array:");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",", numbers));

            Console.WriteLine("Enter start index:");
            int indexStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end index:");
            int indexEnd = int.Parse(Console.ReadLine());

            int resultMax = MaxNumberSubArray(numbers, indexStart, indexEnd);
            Console.WriteLine("The max number between index {0} and index {1} is {2}", indexStart, indexEnd, resultMax);
          
            Console.WriteLine(string.Join(",", SortDescending(numbers)));
            Console.WriteLine(string.Join(",", SortAscending(numbers)));

        }

        static int MaxNumberSubArray(int [] numbers, int indexStart, int indexEnd)
        {
            int lenght = indexEnd-indexStart;
            //int[] subArray = new int[lenght];
            int [] subArray = new List<int>(numbers).GetRange(indexStart, indexEnd).ToArray();
            int max = subArray.Max();
            // biggest between index start and indexend inclusive!
            return max;

        }
        //Using it write another method that sorts an array in ascending / descending order.
        static int[] SortDescending(int[] numbers)
        {
             List<int> listNumbers = numbers.ToList<int>();
             //int max = listNumbers.Max();// = sorted[0]
             //List<int> listSortedDescending = new List<int>();

             int[] listSortedDescending = new int[numbers.Length];

            for (int i = 0; i<numbers.Length; i++)
            {
                listSortedDescending[i] = listNumbers.Max();
                int currMax = listSortedDescending[i];
                listNumbers.Remove(currMax);
            }
            return listSortedDescending;

        }
        static int[] SortAscending(int[] numbers)
        {
            List<int> listNumbers = numbers.ToList<int>();
            //int max = listNumbers.Max();// = sorted[0]
            //List<int> listSortedDescending = new List<int>();

            int[] listSortedAscending = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                listSortedAscending[i] = listNumbers.Min();
                int currMin = listSortedAscending[i];
                listNumbers.Remove(currMin);
            }
            return listSortedAscending;

        }

    }
}
