using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Enter sideA:");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter sideB:");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());
            double area = ((sideA + sideB) / 2) * height;

            Console.WriteLine("Area of trapezoid is " + area);

        }
    }

