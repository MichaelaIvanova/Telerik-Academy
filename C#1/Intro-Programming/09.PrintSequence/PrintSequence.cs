using System;

    class PrintSequence
    {
        static void Main()
        {
            for (int i = 2; i < 11; i += 2)//common memmber
            {
                Console.Write("{0},", i);
                Console.Write("-{0},", i + 1);
            }
        }
    }

