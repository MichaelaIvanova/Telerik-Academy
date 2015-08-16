using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_integers
{
    class Program
    {
        //You are given a sequence of positive integer values written into a string, separated by spaces.
        //Write a function that reads these values from given string and calculates their sum.
        static void Main(string[] args)
        {
            Console.WriteLine("enter integers separated with space");
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(input, s => int.Parse(s));
            int sum = numbers.Sum();

            Console.WriteLine("the sum is {0}", sum);
             

        }
    }
}
