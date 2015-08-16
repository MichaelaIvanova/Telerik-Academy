using System;

    class Program
    {
        //Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
        static void Main()

        {
           // int index = Array.BinarySearch(arr, m);
           // Console.WriteLine(index);// the same as the while cycle
            // int [] h =Enumerable.Range(1,100).ToArray();


            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                Console.WriteLine(arr[i]);
            }


            Console.WriteLine("Enter the number you want to find:");
            int m = int.Parse(Console.ReadLine());

            int first = 0;
            int last = arr.Length;

           
            while ( first <= last) 
            {
                int middle = (first + last) / 2;
                if (m < arr[middle])
                {
                    last = middle - 1;
                }
                if(m > arr[middle])
                {
                    first = middle + 1;

                }
                else if ( m == arr[middle])
                {
                    Console.WriteLine("the number {0} is at index {1}", m, middle);
                    break;
                }

            }



         






                // binary search algo
                //do
                //{
                //    // if the key of the item we're looking for is bigger then the current item, we operate on the right
                //    if (m > arr[index])
                //    {
                //        lowerBound = index;
                //    }
                //   // else if (m < arr[index]) // else operate on the left
                //    {
                //        upperBound = index;
                //    }

                //    // update index
                //   // index = lowerBound + (upperBound - lowerBound) / 2;


                ////} while (arr[index] != m && upperBound - lowerBound > 1);

            //Console.WriteLine(arr[index] == m ? "Item with key {0} was found at {1}" : "Item with key {0} was not found", m, index);
        }
    }

