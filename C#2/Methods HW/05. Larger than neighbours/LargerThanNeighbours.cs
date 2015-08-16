using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class LargerThanNeighbours
    {
        //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
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

            Console.WriteLine("enter index to check whether is the biggest between 2 neighbours");
            int indexToCheck = int.Parse(Console.ReadLine());
            if (indexToCheck >= numbers.Length|| indexToCheck==0)
                Console.WriteLine("error");
            return;

            bool result = CheckIndex(numbers, indexToCheck);
            Console.WriteLine("Are the element at index {0} the biggest: {1}", indexToCheck, result);
        }

        static bool CheckIndex (int [] array, int index)
        {
            bool isBiggest = false;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                    isBiggest = true;
                else
                    isBiggest = false;
            }
                return isBiggest;
        }
    }
          
}

