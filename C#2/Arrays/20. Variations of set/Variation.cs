﻿using System;
using System.Linq;

//Problem 20.* Variations of set

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example:

//N	K	   result
//3	2	  {1, 1} 
//        {1, 2} 
//        {1, 3} 
//        {2, 1} 
//        {2, 2} 
//        {2, 3} 
//        {3, 1} 
//        {3, 2} 
//        {3, 3}

class Variations
{
    // reference to the array
    static int[] refStore;

    public static void variations(int n, int k, int ind)
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
        {
            for (int i = 1; i <= n; i++)
            {
                // variations are from 1 to n, so we can get all number from 1 to n by using the indeces "i"
                refStore[ind] = i;
                // recursive call
                variations(n, k, ind + 1);
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
        variations(n, k, 0);
    }
}
