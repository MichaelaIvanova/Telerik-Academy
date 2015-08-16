using System;

    class SumOf3Numbers
    {

        //Write a program that reads 3 real numbers from the console and prints their sum.
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double sum = a+b+c;
                
            checked
                    {
                   Console.WriteLine("The sum of a+b+c is {0}", sum);
                    }
           



        }
    }

