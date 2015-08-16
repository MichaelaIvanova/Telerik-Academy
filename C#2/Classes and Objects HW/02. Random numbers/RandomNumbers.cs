using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Random_numbers
{
    class RandomNumbers
    {
        //Write a program that generates and prints to the console 10 random values in the range [100, 200].
        static void Main(string[] args)
        {
            Random generator = new Random();// задължително извън цикъла за да работи наистина рандом

            for (int i = 0; i < 10; i++)
            {
                int randomNum = generator.Next(100, 201);// за да включи и 200;
                Console.WriteLine(randomNum);

            }
        }
    }
}
