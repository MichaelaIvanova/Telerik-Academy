using System;

    class CompareArryas
    {
        //Write a program that reads two integer arrays from the console and compares them element by element.
        static void Main ()
        {
            Console.WriteLine("Enter lenght N for the first Array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter lenght M for the first Array:");
            int m = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[m];

            for(int i=0; i<array1.Length; i++)
            {
                Console.WriteLine("In array1 [{0}] =", i);
                array1[i] = int.Parse(Console.ReadLine());
                
            }
            for (int j = 0; j < array2.Length; j++)
            {
                Console.WriteLine("In array2 [{0}] =", j);
                array2[j] = int.Parse(Console.ReadLine());
            }

            if (array1.Length!=array2.Length)
            {
                Console.WriteLine("Arrays have different lenght so they are different");
            }
            else
            {
                bool arequal = true;

               for (int i= 0; i<array1.Length;i++)
               {
                   for (int j = 0; j<array2.Length; j++)
                   {
                       if (array1[i] == array2[j])
                       {
                           arequal = true;
                       }
                       else
                       {
                           arequal = false;

                       }
                   }
               }
               Console.WriteLine("Are arrays equal:{0}",arequal);
                   

            }


        }
    }

