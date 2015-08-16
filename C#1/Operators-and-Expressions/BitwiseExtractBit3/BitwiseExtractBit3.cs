using System;

    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer number:");
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int nAndMask = n & mask;
            int result = nAndMask >> p;     
            Console.WriteLine(result);  


        }
    }

