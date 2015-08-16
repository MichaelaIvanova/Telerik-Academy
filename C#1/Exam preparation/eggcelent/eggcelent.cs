using System;

    class eggcelent
    {
        static void Main()
        {

            int n = 6;
            int totalHeightY = 2 * n;
            int totalWidthX = (3 * n) + 1;

            int heighY1 = n / 2;

            Console.Write(new string('.', n + 1));
            Console.Write(new string('*', n - 1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();

            for (int i = 1; i <= heighY1; i++)
            {
                int newY = heighY1 - i;
                int newX =totalWidthX - (2 * newY);
                Console.Write(new string('.', newX));
                Console.Write('*');

                Console.Write(new string('.', newX));

                Console.Write('*');
                Console.WriteLine(new string('.', newY));

            }

        }
    }

