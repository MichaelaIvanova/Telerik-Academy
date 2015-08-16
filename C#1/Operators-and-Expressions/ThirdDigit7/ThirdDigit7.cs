using System;

    class ThirdDigit7
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 1000 > 699 && number % 1000 < 800)
            {
                Console.WriteLine("The third digit of the number {0} is 7", number);
            }
            else
            {
            Console.WriteLine("The third digit IS NOT 7.");
            }


        }
    }

