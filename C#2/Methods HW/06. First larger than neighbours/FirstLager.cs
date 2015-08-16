using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
   
    //Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
    //Use the method from the previous exercise.
    class FirstLager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of integer array:");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",", numbers));

            //Console.WriteLine("enter index to check whether is the biggest between 2 neighbours");
            //int indexToCheck = int.Parse(Console.ReadLine());
            //if (indexToCheck >= numbers.Length || indexToCheck == 0)
               // Console.WriteLine("error");
            //return;

            int result =FirstBiggest(numbers);
            Console.WriteLine("The fist biggest between 2 elements in the array is {0}, so it do not exists", result);
        }

        static int FirstBiggest(int[] array)
        {
            bool isBiggest = false;
            int biggest = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    isBiggest = true;
                    biggest += array[i];
                    break;
                    
                }
            }

            if (isBiggest)
                return biggest;
            else
                return -1;
        }

            
        }
    }

