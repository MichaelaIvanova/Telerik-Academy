﻿using System;

    class NUmberasWords
    {
        //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            string[] wordUpper = {"Zero","One","Two","Three",
        "Four","Five", "Six","Seven","Eight","Nine","Ten",
        "Eleven","Twelve","Thirteen","Fourteen","Fifteen", 
        "Sixteen","Eighteen","Seventeen" ,"Nineteen"};
            string[] wordLower = {string.Empty,"one","two","three","four",
        "five","six","seven","eight","nine","ten","eleven",
        "twelve","thirteen","fourteen","fifteen","sixteen",
        "seventeen","eighteen","nineteen"};
            string[] wordLowerTens = {string.Empty,string.Empty,
        "twenty","thirty","forty","fifty","sixty","seventy",
        "eighty","ninety"};
            string[] wordTens = {string.Empty,string.Empty,"Twenty","Thirty","Forty",
        "Fifty","Sixty","Seventy","Eighty","Ninety"};
            int remainderUnits = n % 10;
            int quotientUnit = n / 10;
            int remainderTens = quotientUnit % 10;
            int quotientTens = quotientUnit / 10;
            int remainderHundreds = quotientTens % 10;

            if (n >= 0 && n <= 19)
            {
                Console.WriteLine("{0}", wordUpper[n]);
            }
            else if (n >= 20 && n <= 99)
            {
                if (n % 10 == 0)
                {
                    Console.WriteLine("{0}", wordTens[n / 10]);
                }
                else if (n % 10 != 0)
                {
                    Console.WriteLine("{0} {1}", wordTens[remainderTens], wordLower[remainderUnits]);
                }
            }
            else if (n % 100 == 0)
            {
                Console.WriteLine("{0} hundred", wordUpper[n / 100]);
            }
            else if (n % 100 != 0 && (remainderTens == 0 || remainderTens == 1))
            {
                if (remainderTens == 0)
                {
                    Console.WriteLine("{0} hundred and {1}",
                    wordUpper[remainderHundreds], wordLower[remainderUnits]);
                }
                else if (remainderTens == 1)
                {
                    Console.WriteLine("{0} hundred and {1}", wordUpper[remainderHundreds], wordLower[remainderUnits + 10]);
                }
            }
            else if (n % 100 != 0 && remainderTens > 1)
            {
                if (remainderUnits != 0 && remainderTens > 1)
                {
                    Console.WriteLine("{0} hundred and {1} {2}", wordUpper[remainderHundreds], wordLowerTens[remainderTens], wordLower[remainderUnits]);
                }
                else if (remainderTens > 1)
                {
                    Console.WriteLine("{0} hundred and {1}", wordUpper[remainderHundreds], wordLowerTens[remainderTens]);
                }
            }
        }
    }


