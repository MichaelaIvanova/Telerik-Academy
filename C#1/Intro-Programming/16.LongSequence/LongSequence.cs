using System;

    class LongSequence
    {
        static void Main()
          {
              for (int i = 2; i < 1001; i+=2 )//common memmber
               {
                   Console.Write("{0},", i);
                   Console.Write("-{0},", i+1);
               }
          }
    }

