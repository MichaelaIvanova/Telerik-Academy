using System;

    class QuadraticEquation
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
        static void Main()
        {
            Console.WriteLine("Enter coeficient a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coeficient b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter constant c:");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - (4 * a * c);

            if (d <= 0)
            {
                Console.WriteLine("No real squire roots!");
            }
            else
            {
                double dR = Math.Sqrt(d);
                Console.WriteLine("The descreminat D is {0}", d);
                double root1 = (-b + dR) / (2 * a);
                double root2 = (-b - dR) / (2 * a);

                Console.WriteLine("root 1 is : {0}, root 2 is {1}", root1, root2);
            }


        }
    }

