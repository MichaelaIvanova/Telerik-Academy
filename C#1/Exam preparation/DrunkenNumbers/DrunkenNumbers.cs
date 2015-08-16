using System;

class DrunkenNumbers
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        long sumMitko = 0, sumVladko = 0;
        for (int i = 0; i < N; i++)
        {
            string number = Console.ReadLine();
            long num = long.Parse(number);
            // check if the number is negative
            if (num < 0)
            {
                num *= -1; // if it is make it positive
            }
            number = num.ToString();
            // if the number is longer than 9 digits
            long digit = 0;
            if (number.Length > 9)
            {
                while (number.Length > 9)
                {
                    digit = num % 10;
                    num = num / 10;
                    number = num.ToString();
                }
            }

            if (number.Length % 2 == 0)
            {
                for (int j = 0; j < number.Length / 2; j++)
                {
                    digit = num % 10;
                    sumVladko += digit;
                    num = num / 10;
                }
                for (int j = 0; j < number.Length / 2; j++)
                {
                    digit = num % 10;
                    sumMitko += digit;
                    num = num / 10;
                }
            }
            else
            {
                for (int j = 0; j < number.Length / 2 + 1; j++)
                {
                    digit = num % 10;
                    sumVladko += digit;
                    num = num / 10;
                }
                for (int j = 0; j < number.Length / 2 + 1; j++)
                {
                    sumMitko += digit;
                    digit = num % 10;
                    num = num / 10;
                }
            }
        }

        long difference = 0;
        if (sumMitko == sumVladko)
        {
            difference = sumVladko + sumMitko;
            Console.WriteLine("No {0}", difference);
        }
        else if (sumMitko > sumVladko)
        {
            difference = sumMitko - sumVladko;
            Console.WriteLine("M {0}", difference);
        }
        else
        {
            difference = sumVladko - sumMitko;
            Console.WriteLine("V {0}", difference);
        }
    }
}