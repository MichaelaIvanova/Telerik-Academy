using System;

    class Program
    {
        static void Main()
        {          
            long sumEven = 0;
            long sumOdd = 0;
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
            for (int i = 0; i< number.Length ; i++)
            {  
                digit = num % 10;
                num = num / 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
            }

            if (sumEven>sumOdd)
            {
                Console.WriteLine("right {0}", sumEven);
            }
            else if (sumOdd>sumEven)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            else if (sumEven==sumOdd)
            {
                Console.WriteLine("straight {0}", sumOdd);
            }
        }
    }

