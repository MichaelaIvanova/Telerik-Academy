﻿using System;
using System.Linq;

//Problem 21.* Combinations of set

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example:

//N	    K	result
//5	    2	{1, 2} 
//          {1, 3} 
//          {1, 4} 
//          {1, 5} 
//          {2, 3} 
//          {2, 4} 
//          {2, 5} 
//          {3, 4} 
//          {3, 5} 
//          {4, 5}

class Combos
{
    // reference to the array
    static int[] refStore;

    public static void combinations(int n, int k, int ind, int newStart)
    {
        if (k <= ind)
        {
            // print variation
            string variation = "{";

            for (int i = 0; i < k; i++)
            {
                variation += refStore[i] + ",";
            }

            Console.WriteLine(variation.TrimEnd(',') + "}");

        }
        else
        {   // no repetitions, so we wont start from 1, but from the last index + 1
            for (int i = newStart; i <= n; i++)
            {
                // use the indeces to get the numbers in 1...N
                refStore[ind] = i;
                // recursive call
                combinations(n, k, ind + 1, i + 1);
            }
        }
    }


    static void Main()
    {
        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("K:");
        int k = int.Parse(Console.ReadLine());

        refStore = Enumerable.Range(1, n).ToArray();
        combinations(n, k, 0, 1);
    }
}

