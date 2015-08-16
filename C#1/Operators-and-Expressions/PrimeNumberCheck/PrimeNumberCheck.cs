using System;

    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            int primeCount = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    primeCount++;
                }
            }
            
            bool isPrime = true;
            if (primeCount > 2)
            {
                isPrime = false;
            }

            Console.WriteLine("This number is prime = " + isPrime);


        }
    }

