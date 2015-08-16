using System;

    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Enter rectangle width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rectangle height:");
            double height = double.Parse(Console.ReadLine());
            if (width < 0 || height < 0)
            {
                Console.WriteLine("Error use only positive values");
            }

            double area =(width * height);
            double perimeter = (2 * (width + height));

            Console.WriteLine("The rectangle area is {0} and the perimeter is {1}", area, perimeter);

        }
    }

