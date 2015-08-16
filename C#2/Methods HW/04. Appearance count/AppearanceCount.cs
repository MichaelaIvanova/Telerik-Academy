using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        //Write a method that counts how many times given number appears in given array.
        //Write a test program to check if the method is workings correctly.
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

            Console.WriteLine("enter integer to check");
            int numberToCount = int.Parse(Console.ReadLine());
            int result = CountSameNumbers(numbers, numberToCount);
            Console.WriteLine("Number {0} appears {1} times", numberToCount, result);

        }

        static int CountSameNumbers(int[] numbers, int numberToCheck)
        {
            int count = 0;
       foreach (int number in numbers)
          {
           if (number == numberToCheck)
               count++;
          }
            return count;
        }

    }
}