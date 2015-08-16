using System;

class ZeroSubset
{
    //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    static void Main()
    {
        Console.WriteLine("Enter 5 integer separated by space:");
        string[] num = Console.ReadLine().Split(' ');
        int[] number = new int[num.Length];
        int sum;
        bool found = false;

        for (int i = 0; i < 5; i++)
        {
            number[i] = Convert.ToInt32(num[i]);
        }

        for (int i = 0; i < 5; i++)
        {
            sum = 0;

            for (int j = i; j < 5; j++)
            {

                sum = sum + number[j];
                if (sum == 0)
                {

                    found = true;

                    for (int k = i; k < j; k++)
                    {
                        Console.Write("{0} + ", number[k]);
                    }
                    Console.Write(number[j]);
                    Console.Write(" 0\n");
                }
                else
                {
                    Console.WriteLine("No zero subset");
                }
            }
        }
    }
}
