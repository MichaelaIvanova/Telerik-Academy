using System;

    class Program
    {
        //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                
            }

            //int min = arr[0];
            //int max = arr[0];
            //for (int i = 0; i < n; i++)
            //{
            //    if (min > arr[i]) min = arr[i];
            //    if (max < arr[i]) max = arr[i];
            //}
            //Console.WriteLine("The minimum is: {0}", min);
            //Console.WriteLine("The maximum is: {0}", max);

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Selection sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


        }
    }

