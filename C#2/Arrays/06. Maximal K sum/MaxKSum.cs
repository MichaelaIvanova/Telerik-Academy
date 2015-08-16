using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int index = 0; index < n; index++)
            {
                Console.Write("Enter element {0}: ", index);
                arr[index] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter number of elements to sum: ");
            int k = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            int currentSum = 0;
            int firstOfSequence = 0;

            for (int index = 0; index < n + 1 - k; index++)
            {
                for (int add = 0; add < k; add++)
                {
                    currentSum += arr[index + add];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstOfSequence = index;
                }
                currentSum = 0;
            }

            Console.Write("The {0} consecutive elements with maximum sum are: ", k);
            for (int index = firstOfSequence; index < firstOfSequence + k; index++)
            {
                Console.Write("{0} ", arr[index]);
            }
        }
    }