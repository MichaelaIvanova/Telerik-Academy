using System;

    class BinaryToDecimal
    {
        //Using loops write a program that converts an integer number to its binary representation.
        //The input is entered as long. The output should be a variable of type string.
        //Do not use the built-in .NET functionality.
        static void Main()
        {
            long decimalN = long.Parse(Console.ReadLine());
            string binary = string.Empty;
            long result = 0;
            long quotient = 1; //result of devision
           while (quotient!=0)
           {
               result = decimalN % 2;
               quotient = decimalN / 2;
               binary += result.ToString();
               decimalN = quotient;
           }
           char[] valueChars = binary.ToCharArray();
           Array.Reverse(valueChars);
           for (int i = 0; i < binary.Length; i++)
           {
               Console.Write("{0}", valueChars[i]);
           }
           Console.WriteLine();





        }
    }

