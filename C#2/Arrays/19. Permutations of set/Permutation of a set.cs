﻿using System;
using System.Linq;
using System.Collections;
//Problem 19.* Permutations of set

//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//Example:

//N	    result
//3	    {1, 2, 3} 
//      {1, 3, 2} 
//      {2, 1, 3} 
//      {2, 3, 1} 
//      {3, 1, 2} 
//      {3, 2, 1}

class Permutations
{
    static int[] refStore;
    public static void permutations(int n)
    {
        // recursion bottom
        if (n == 0)
        {
            return;
        }

        for (int j = 0; j < n; j++)
        {
            // recursive call
            permutations(n - 1);
            // on the way back, print
            if (n == 2)
            {
                string print = "{";
                foreach (int number in refStore)
                {
                    print += number + ",";
                }
                Console.WriteLine(print.TrimEnd(',') + "}");
            }

            // shuffle the array
            int store = refStore[refStore.Length - n];
            Array.Copy(refStore, refStore.Length - n + 1, refStore, refStore.Length - n, n - 1);
            refStore[refStore.Length - 1] = store;


        }
        
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        refStore = Enumerable.Range(1, n).ToArray();
        permutations(refStore.Length);
    }
}

