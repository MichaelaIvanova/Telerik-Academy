using System;

    class Calculate
    {
 //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
        static void Main()
        {
            Console.WriteLine("Enter integer n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer k:");
            int k = int.Parse(Console.ReadLine());

            long factorialN = 1;
            long factorialK = 1;
            long factorialDiff = (n-k);
            double result = 1;
            
            if ( (1 < k)  && (n < 100) && (k<n))
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;

                    if (i <= k)// задължително, защото иначе резултатът е 1
                    {
                        factorialK *= i;
                        factorialDiff *=i;
                    }

                }
                for (int i = 1; i <= n - k; i++)// n-k = max value
                {
                    factorialDiff *= i;
                }
                Console.WriteLine("{0}", factorialN /
                (factorialK * (factorialDiff)));


            }

            }
        }
    

