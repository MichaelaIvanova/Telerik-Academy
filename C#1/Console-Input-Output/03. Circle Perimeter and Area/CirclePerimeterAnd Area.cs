using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Enter circle radius:");
            double r = double.Parse(Console.ReadLine());
            double perimeter = Math.PI * 2 * r;
            double area = Math.Pow(r,2)* Math.PI;
            Console.WriteLine(" The perimeter is {0:F2} and the area is {1:F3}", perimeter, area);


        }
    }

