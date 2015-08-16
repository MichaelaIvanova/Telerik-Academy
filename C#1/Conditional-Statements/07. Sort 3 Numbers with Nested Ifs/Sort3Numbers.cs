using System;

class Sort3Numbers
{
    //Write a program that enters 3 real numbers and prints them sorted in descending order.
    static void Main()
    {
        Console.WriteLine("Enter three real numbers");
        Console.WriteLine("Enter number a:");
        double numberA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double numberB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c:");
        double numberC = double.Parse(Console.ReadLine());
        double a = 0;
        double b = 0;
        double c = 0;
        if ((numberA <= numberB) && (numberA <= numberC))
        {
            a = numberA;
            if (numberB <= numberC)
            {
                b = numberB;
                c = numberC;
            }
            else
            {
                b = numberC;
                c = numberB;
            }
        }
        else if ((numberB <= numberA) && (numberB <= numberC))
        {
            a = numberB;
            if (numberA <= numberC)
            {
                b = numberA;
                c = numberC;
            }
            else
            {
                b = numberC;
                c = numberA;
            }
        }
        else if ((numberC <= numberA) && (numberC <= numberB))
        {
            a = numberC;
            if (numberA <= numberB)
            {
                b = numberA;
                c = numberC;
            }
            else
            {
                b = numberB;
                c = numberA;
            }
        }
        Console.WriteLine("{0} {1} {2}", a, b, c);
    }
}