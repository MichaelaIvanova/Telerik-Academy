using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_largest_number
{
    class LargestNumbers
    {
        //Write a method GetMax() with two parameters that returns the larger of two integers.
        //Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int bigger = GetMax(numberOne, numberTwo);
            Console.WriteLine(GetMax(bigger,numberThree));
        }
        static int GetMax(int numberOne, int numberTwo)
        {
            int max = numberOne;
            if (numberOne<numberTwo)
            {
                max = numberTwo;
            }
            return max;
        }
    }
}
