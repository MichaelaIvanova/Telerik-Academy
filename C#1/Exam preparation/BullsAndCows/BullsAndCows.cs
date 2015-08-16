using System;
using System.Text;

class BullsAndCows
{
    static void Main()
    {
        ushort secretNumber = ushort.Parse(Console.ReadLine());
        byte[] number = new byte[4];
        for (int i = 3; i >= 0; i--)
        {
            byte digit = (byte)(secretNumber % 10);
            number[i] = digit;
            secretNumber /= 10;
        }
        byte[] original = new byte[4];
        for (int i = 0; i < 4; i++)
        {
            original[i] = number[i];
        }

        byte bulls = byte.Parse(Console.ReadLine());
        byte cows = byte.Parse(Console.ReadLine());

        byte counterBulls = 0, counterCows = 0;
        StringBuilder result = new StringBuilder();

        for (int num = 1111; num <= 9999; num++)
        {
            bool isZero = false;
            int check = num;
            byte[] guess = new byte[4];
            for (int i = 3; i >= 0; i--)
            {
                byte digit = (byte)(check % 10);
                // check if number contains 0
                if (digit == 0)
                {
                    isZero = true;
                    break;
                }
                guess[i] = digit;
                check /= 10;
            }
            if (isZero)
            {
                continue;
            }

            //check for bulls
            for (int i = 3; i >= 0; i--)
            {
                if (guess[i] == number[i])
                {
                    counterBulls++;
                    number[i] = 0;
                    guess[i] = 0;
                }
            }

            //check for cows
            if (counterBulls == bulls)
            {
                for (int i = 3; i >= 0; i--)
                {
                    for (int j = 3; j >= 0; j--)
                    {
                        if (i != j && guess[i] == number[j] && guess[i] > 0 && number[j] > 0)
                        {
                            counterCows++;
                            guess[i] = 0;
                            number[j] = 0;
                        }
                    }
                }
                if (counterCows == cows)
                {
                    result.Append(num + " ");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                number[i] = original[i];
            }
            counterBulls = counterCows = 0;
        }

        if (result.Length == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            result.Length--;
            Console.WriteLine(result);
        }
    }
}

