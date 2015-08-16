using System;

    class BiggestNumberofFive
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            double c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the forth number:");
            double d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth number:");
            double e = int.Parse(Console.ReadLine());

             
            double BiggestNumber = a;

        if (BiggestNumber < b)
        {
            BiggestNumber = b;
        }
        if (BiggestNumber < c)
        {
            BiggestNumber = c;
        }
        if (BiggestNumber < d)
        {
            BiggestNumber = d;
        }
        if (BiggestNumber < e)
        {
            BiggestNumber = e;
        }
        Console.WriteLine("The greatest variable is: {0}", BiggestNumber);

        }
    }

