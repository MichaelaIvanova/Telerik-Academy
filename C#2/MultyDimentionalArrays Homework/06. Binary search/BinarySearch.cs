using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_search
{
    class BinarySearch
    {
        //Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter te size of the int array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for ( int i = 0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter number");
            int k = int.Parse(Console.ReadLine());

            Array.BinarySearch(arr, k);
            int indexOfK = arr.ToList().IndexOf(k);
            if (indexOfK >= 0)
            {
                Console.WriteLine("The index of k is {0}", indexOfK);
            }
            else
            {
                List<int> arrK = arr.ToList();
                arrK.Add(k);
                int[] arrwithK = arrK.ToArray();
                Array.Sort(arrwithK);
                int indexKNew = arrwithK.ToList().IndexOf(k);
                Console.WriteLine("the biggest number in the array before K is with index {0}, and the element is {1}", indexKNew - 1, arrwithK[indexKNew - 1]);
            }

        }
    }
}
