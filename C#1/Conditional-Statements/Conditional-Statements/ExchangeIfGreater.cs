using System;


    class ExchangeIfGreater
    {

        // Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
        static void Main()
        {
            Console.WriteLine(" Enter the first double a =");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second double b =");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(" a = {0}, b = {1}", a, b);
            double c = a;

            if (a > b)
            {
                c = a;
                a = b;
                b = c;

                Console.WriteLine("{0} {1}", a, b);
            }

            else
            {
              
                Console.WriteLine(" a = {0}, b = {1}", a, b);

            }
        }
    }

