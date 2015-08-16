using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_elements_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
             // zero test
        //int[] number = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        //int size = 9;

        Console.WriteLine("Size:");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine("Array:");

        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] store = new int[size];
        int[] sequence = store;
        int maxLength = 0;

        // using binary representation to generate all possible sequence
        for (int i = 0, currentLength = 0; i < (2 << size) - 1; i++)
        {
            bool increasing = true;

            for (int j = 0, storeIndex = 0; j < size; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    // store the current sequence
                    store[storeIndex++] = numbers[j];
                    // if anything is stored
                    if (storeIndex > 1)
                    {
                        
                        if (store[storeIndex - 2] > store[storeIndex - 1])
                        {
                            increasing = false;
                        }
                    }
                    // increment the legth of the current sequence
                    currentLength++;
                }
            }
            // if new increasing sequence that is longer than the last
            if (increasing && currentLength > maxLength)
            {
                maxLength = currentLength;
                sequence = store;
                store = new int[size];
                
            }
            //reset
            currentLength = 0;
        }

        for (int i = 0; i < maxLength; i++)
            Console.Write(sequence[i]+ ",");
    }
}
