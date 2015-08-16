using System;
using System.Numerics;

    class SecretNumbers
    {
        //The special sum of a number is the sum of its digits calculated by the following algorithm
        //•	Each digit with odd position from right to left adds to the special sum its value multiplied by the square of its position in the number.
        //•	Each digit with even position from right to left adds to the special sum the square of its value multiplied by its position in the number.
        //For example if the number is 37 its special sum is 7 * 12 + 32 * 2 = 25. Another example: if the number is 111 its special sum is 1 * 12 + 12 * 2 + 1 * 32 = 12.
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            int specialsum = 0;
            BigInteger number = n;

            if (number < 0)
            {
                number *= -1;
            }
            int position = 1;


            while (number>0)
            {
                int digit = (int) (number % 10);
                number /= 10;
                if ( position %2 == 0)
                {
                    specialsum += digit * digit * position;
                }
                else
                {
                    specialsum += digit * position * position;
                }
                ++position;
            }
            Console.WriteLine(specialsum);

            int sequencelenght = specialsum % 10;

            if (sequencelenght == 0)
            {
                Console.Write("{0} has no secret alpha-sequence", n);
            }

            else
            {
                int start = specialsum % 26;
                //0-25
                // 'A' -'Z'
               // Console.WriteLine(char('A' + 5));//показва 5та буква от азбуката глава
                for ( int i = 0; i<sequencelenght; i++)
                {
                    Console.Write((char)('A'+(start +i)%26));// zapo4va ot a
                }
                Console.WriteLine();
            }

          

        }
    }

