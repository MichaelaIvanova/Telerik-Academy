using System;

    class PrintASCIItable
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (short i = 0; i <= 255; i++)
            Console.WriteLine("{0} in ASCII is {1}", i, (char)i); 

        }
    }

