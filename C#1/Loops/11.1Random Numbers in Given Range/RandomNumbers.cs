using System;

    class RandomNumbers
    {
        //Write a program that enters 3 integers n, min and max (min != max) 
        //and prints n random numbers in the range [min...max].
        static void Main()
        {
            Console.WriteLine("Enter integers for n, min and max, where (min < max) :");
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            if (min > max)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();




        }
    }

