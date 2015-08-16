using System;

    class PrintNumberFrom1toN
    {
        //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

