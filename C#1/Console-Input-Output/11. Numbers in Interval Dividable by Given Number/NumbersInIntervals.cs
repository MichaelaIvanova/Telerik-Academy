using System;


    class NumbersInIntervals
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
        static void Main()
        {
            Console.WriteLine("Enter interger lower limit:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter interger upper limit:");
            int b = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                if (i%5 == 0)
                {
                    Console.WriteLine("Number {0} is can be devided by 5",i);
                    counter++;
                } 
            }
            Console.WriteLine(counter);
        }


    }

