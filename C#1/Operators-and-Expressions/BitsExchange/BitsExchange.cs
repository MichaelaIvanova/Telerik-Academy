using System;

    class BitsExchange
    {
        //write a program that takes bits 3,4,5 and puts them into the place of bits 24,25,26
        static void Main()
       {

        Console.WriteLine("Input a positive integer number:");
        uint number = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        for (int i = 3; i < 6; i++)
        {
            int position = i;
            int mask = 1 << position;
            long numberWithMask = number & mask;
            long bit = numberWithMask >> position;
            Console.WriteLine("The value of the bit number {0} is {1}", position, bit);

            int position2 = i + 21;
            int mask2 = 1 << position2;
            long numberWithMask2 = number & mask2;
            long bit2 = numberWithMask2 >> position2;
            Console.WriteLine("The value of the bit number {0} is {1}", position2, bit2);

            bool different = bit != bit2;

            if (different)
            {
                long bitA = bit;
                bit = bit2;
                bit2 = bitA;

                bool vZeroOrOne = (bit == 0);
                if (vZeroOrOne)
                {
                    int maskSmqna1 = ~(1 << position);
                    long result = number & maskSmqna1;


                    int maskSmqna2 = 1 << position2;
                    long resultFinal = result | maskSmqna2;
                    Console.WriteLine(resultFinal);
                    number = (uint)resultFinal;
                    Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                }
                else
                {
                    int maskSmqna1 = 1 << position;
                    long result = number | maskSmqna1;


                    int maskSmqna2 = ~(1 << position2);
                    long resultFinal = result & maskSmqna2;
                    Console.WriteLine(resultFinal);
                    number = (uint)resultFinal;
                    Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                }

            }
            else
            {
                number = number;
                Console.WriteLine(number);
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }

        }

    }
}
      
  

