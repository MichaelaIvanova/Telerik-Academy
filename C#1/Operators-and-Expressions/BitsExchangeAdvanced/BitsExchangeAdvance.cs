using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine("Input a positive integer number:");
        uint number = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("The bitwise representaion of the number is:");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("\nExchange of bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}:");
        Console.WriteLine("Input p:");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input q:");
        int q = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input k:");
        int k = Convert.ToInt32(Console.ReadLine());

        int i;
        long resultFinal = 0;

        bool pBiggerQ = p > q;
        if (pBiggerQ)
        {
            int tempP = p;
            p = q;
            q = tempP;
        }

        bool isOverlap = (q - p) < k;
        bool isOutOfRange = (((q + k) > 32) || (p < 0));

        if (isOverlap)
        {
            Console.WriteLine("The bits are overlapping.");
        }
        else if (isOutOfRange)
        {
            Console.WriteLine("The bits are out of range.");
        }
        else
        {
            for (i = p; i < (p + k); i++)
            {
                int position = i;
                int mask = 1 << position;
                long numberWithMask = number & mask;
                long bit = numberWithMask >> position;

                int position2 = i + (q - p);
                int mask2 = 1 << position2;
                long numberWithMask2 = number & mask2;
                long bit2 = numberWithMask2 >> position2;

                bool different = bit != bit2;

                if (different)
                {
                    long bitA = bit;
                    bit = bit2;
                    bit2 = bitA;

                    bool vZeroOrOne = (bit == 0);
                    if (vZeroOrOne)
                    {
                        int maskChange1 = ~(1 << position);
                        long result = number & maskChange1;

                        int maskChange2 = 1 << position2;
                        resultFinal = result | maskChange2;
                        number = (uint)resultFinal;
                    }
                    else
                    {
                        int maskChange1 = 1 << position;
                        long result = number | maskChange1;

                        int maskChange2 = ~(1 << position2);
                        resultFinal = result & maskChange2;
                        number = (uint)resultFinal;
                    }
                }
            }
            Console.WriteLine("The bitwise representaion of the exchaged number is:");
            Console.WriteLine(Convert.ToString(resultFinal, 2).PadLeft(32, '0'));
            Console.WriteLine("After the bit exchange the number is:\n{0}", resultFinal);
        }
    }
}
