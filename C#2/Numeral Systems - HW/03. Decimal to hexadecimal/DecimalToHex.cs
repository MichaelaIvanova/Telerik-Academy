using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_to_hexadecimal
{
    class DecimalToHex
    {
        // for positive an for negative!
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer:");
            int decimalNum = int.Parse(Console.ReadLine());
            //int lenght = decimalNum.ToString().Length;
            List<string> hex = new List<string>();

            while (decimalNum > 0)
            {
                int reminder = decimalNum%16;
                string reminderDigit = reminder.ToString();

                switch (reminder)
                {
                    case 10: hex.Add("A"); break;
                    case 11: hex.Add("B"); break;
                    case 12: hex.Add("C"); break;
                    case 13: hex.Add("D"); break;
                    case 14: hex.Add("E"); break;
                    case 15: hex.Add("F"); break;
                    default: hex.Add(reminderDigit); break;
                }
                decimalNum /= 16;
            }

            hex.Reverse();
            string hexNum = string.Join("", hex);
            Console.WriteLine("{0} in Hex is 0x{1}...THis will apper only for positive decimals", decimalNum, hexNum);

            if (decimalNum<0)
            {
                string binary = Convert.ToString(decimalNum, 2);
                int chunkSize = 4;// po tolkova ni trqbvat za da go oburnem v edin symbol
                //each hex digit corresponds to a sequence of 4 binary digits:starighforward

                List<string> binarBy4 = new List<string>();
                for (int i = 0; i < binary.Length; i += 4)
                {
                    if ((i + 4) < binary.Length)
                        binarBy4.Add(binary.Substring(i, 4));
                    else
                        binarBy4.Add(binary.Substring(i));
                }
                //Console.WriteLine(string.Join(","binarBy4));

                List<string> negativeHex = new List<string>();

                for (int i = 0; i<binarBy4.Count; i++)
                {
                    switch (binarBy4[i])
                    {
                        case "0000": negativeHex.Add("0"); break;
                        case "0001": negativeHex.Add("1"); break;
                        case "0010": negativeHex.Add("2"); break;
                        case "0011": negativeHex.Add("3"); break;
                        case "0100": negativeHex.Add("4"); break;
                        case "0101": negativeHex.Add("5"); break;
                        case "0110": negativeHex.Add("6"); break;
                        case "0111": negativeHex.Add("7"); break;
                        case "1000": negativeHex.Add("8"); break;
                        case "1001": negativeHex.Add("9"); break;
                        case "1010": negativeHex.Add("A"); break;
                        case "1011": negativeHex.Add("B"); break;
                        case "1100": negativeHex.Add("C"); break;
                        case "1101": negativeHex.Add("D"); break;
                        case "1110": negativeHex.Add("E"); break;
                        case "1111": negativeHex.Add("F"); break;
                    }
                    
                }
                string finalHexFromBin = string.Join("", negativeHex);
                Console.WriteLine("the hex rep of negative decimal is 0x{0}", finalHexFromBin);                
            }
           
        }
    }
}
