using System;

    class FormattingNumbers
    {
//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c

        static void Main()
        {
            Console.WriteLine("Enter a integer a:");
            int a = int.Parse(Console.ReadLine());
            while (a < 0 || a > 500) //Check number is valid
            {
                Console.WriteLine("Invalid input! Try again!");

            }
            string aBinary = Convert.ToString(a,2).PadLeft(10,'0');
            Console.WriteLine(aBinary);

            Console.WriteLine("Enter a floating-point b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a floating-point c:");
            double c = double.Parse(Console.ReadLine());

// The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

            Console.WriteLine("| {0,-10:X} | {1} | {2,10:F2} | {3,-10:F3} | ", a, aBinary, b, c);

        }
    }

