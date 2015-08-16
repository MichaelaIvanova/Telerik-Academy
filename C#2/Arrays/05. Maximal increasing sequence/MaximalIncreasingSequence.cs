using System;

    class MaximalIncreasingSequence
    {
        //Write a program that finds the maximal increasing sequence in an array.
        static void Main()
        {
        
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int bestSeq = 1;
        int currSeq = 1;
        string currNum = "";
        string bestNum = "";
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                currSeq++;
                currNum += arr[i] + " ";
            }
            else
            {
                if (currSeq > bestSeq)
                {
                    bestSeq = currSeq;
                    currNum += arr[i] + " ";
                    bestNum = currNum;
                }
                currSeq = 1;
                currNum = "";
            }
        }
        if (currSeq > bestSeq)
        {
            currNum += arr[arr.Length - 1];
            bestNum = currNum;
        }
        Console.WriteLine(bestNum);
    }
}
