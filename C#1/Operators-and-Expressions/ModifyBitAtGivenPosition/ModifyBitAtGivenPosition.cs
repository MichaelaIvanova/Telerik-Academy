using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter integer:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2));
        Console.WriteLine("Enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of bit:");
        int valueBit = int.Parse(Console.ReadLine());
       

        if (valueBit==0)
        {
            int mask = ~(1 << p);      
            int nAndMask = n & mask;
            Console.WriteLine(nAndMask);
            Console.WriteLine(Convert.ToString(nAndMask, 2)); 

         }
         if (valueBit == 1)
       
         {
            int mask = 1 << p;
            int nOrMask = n | mask;
            Console.WriteLine(nOrMask);
            Console.WriteLine(Convert.ToString(nOrMask, 2)); 
         }
        else
        {
            Console.WriteLine("Error, invalid Bit value");
        }

    }




}
