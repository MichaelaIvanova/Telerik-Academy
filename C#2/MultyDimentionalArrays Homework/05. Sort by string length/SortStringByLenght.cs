using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_by_string_length
{
    //You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
    class SortStringByLenght
    {
        static void Main()
        {
            Console.WriteLine("enter teh size of the array:");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string [n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine(string.Join(",", arr));

            //char[] arrChar = arr[0].ToCharArray();
            //int lenght = arrChar.Length;
            //Console.WriteLine(lenght);
            // int lenght = 0;


            int maxLenght = arr[0].Length;

            for (int j = 0; j < arr.Length; j++)
            {
                int lenght = arr[j].Length;

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                }

            }
                Console.WriteLine("the longest string has {0} char", maxLenght);

                //arr.OrderBy(arr,)
                string [] sortedArray = arr.OrderBy(i => i.Length).ToArray();// create a copy of the array
                Console.WriteLine(string.Join(",", sortedArray));

        }
      

    }


}
