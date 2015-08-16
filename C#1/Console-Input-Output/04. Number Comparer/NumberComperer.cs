using System;

    class NumberComperer
    {
        static void Main()
        {
            Console.WriteLine("a = ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal bigger = Math.Max(a, b);
            Console.WriteLine("The bigger is {0}", bigger);


        }
    }

