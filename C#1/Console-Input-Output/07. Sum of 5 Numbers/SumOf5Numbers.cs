using System;

class SumOf5Numbers
{
    //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
    static void Main()
    {
        Console.WriteLine("Enter five number on one line, separated with space");
        string input = Console.ReadLine();
        string[] Array = input.Split(' ');
        double[] nums = new double[Array.Length];
        double sum = 0;

        for (int i = 0; i < Array.Length; i++)
        {
            nums[i] = double.Parse(Array[i]);
            Console.WriteLine(nums[i]);
            sum += nums[i];
            
        }
        Console.WriteLine("The sum is {0}", sum);






















    }
}

