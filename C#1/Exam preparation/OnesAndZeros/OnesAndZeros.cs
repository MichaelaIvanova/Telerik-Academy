using System;

class OnesAndZeros
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2).PadLeft(16, '0');
        

        string row0 = ".#.";
        string row1 = "##.";
        string row2 = ".#.";
        string row3 = ".#.";
        string row4 = "###.";
        string zero = ".#.#.";

        for (int i = 0; i <binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                Console.Write(row0);
            }
            else
            {
                Console.Write(row4);
            }
        }
        Console.WriteLine();

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                Console.Write(row1);
            }
            else
            {
                Console.Write(zero);
            }
        }
        Console.WriteLine();
    }
}


