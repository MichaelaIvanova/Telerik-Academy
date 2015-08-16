using System;

    class Program
    {
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
        static void Main()
        {
            Console.WriteLine("Enter integer n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer k:");
            int k = int.Parse(Console.ReadLine());

            int factorialN = 1;
            int factorialK = 1;
            double result = 1;
            
            if ( (1 < k)  && (n < 100) && (k<n))
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;

                    if (i <= k)// задължително, защото иначе резултатът е 1
                    {
                        factorialK *= i;
                    }
                    
                   
                    result = (double)(factorialN / factorialK);  
                }
                Console.WriteLine("The result N!/K! is {0}", result);

            }
            else
            {
                Console.WriteLine("Error, range 1 < k < n < 100");
            }
        }
    }

