using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int result = nAndMask >> p;
            Console.WriteLine(result);  
          
        }
    }

