using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Prime_numbers
{
    class PrimeNumbersSeive
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
        static void Main(string[] args)
        {
            bool[] numbers = new bool[10000000];// default value false

            for (int i = 2; i < Math.Sqrt(numbers.Length); i++)
            {
                if(numbers[i]==false)// turn to true
                {
                    for (int j = i*i; j<numbers.Length; j = j+i)
                    {
                        numbers[j] = true;
                    }
                }


            }
            for (int i = 2;  i < Math.Sqrt(numbers.Length); i++ )
            {
                if (numbers[i] == false)
                {
                    Console.Write("{0} , ", i);
                }

            }
            Console.WriteLine();
        }
    }
}
