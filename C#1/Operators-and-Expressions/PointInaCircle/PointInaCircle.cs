using System;

    class PointInaCircle
    {
        static void Main()
        {
            int circleR = 2, centerX = 0, centerY = 0;
            double pointX = 0, pointY = 0;

            while (!double.TryParse(Console.ReadLine(), out pointX))
            {
                Console.WriteLine("Please, enter valid integer.");
            }
            Console.WriteLine("Provide point Y coordinate:");
            while (!double.TryParse(Console.ReadLine(), out pointY))
            {
                Console.WriteLine("Please, enter valid integer.");
            }

           bool isInCircle = (Math.Pow((pointX - centerX), 2) + Math.Pow((pointY - centerY), 2)) <= Math.Pow(circleR, 2);
           Console.WriteLine("\nProvided point with coords ({0};{1}) is {2}", pointX, pointY, isInCircle ? "inside the circle." : "outside the circle.\n");
        
        }
    }

