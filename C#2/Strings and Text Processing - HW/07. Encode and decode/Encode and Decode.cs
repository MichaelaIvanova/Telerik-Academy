using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Encode_and_decode
{
    class Program
    {
        //Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
        static void Main(string[] args)
        {
            
            string input = "ABCDEeeee";
            string cipher = "ABCD";
            //string input = Console.ReadLine();
           // string cipher = Console.ReadLine();

            StringBuilder inputAd = new StringBuilder().Append(input);
            StringBuilder cipherAD = new StringBuilder().Append(cipher);
            int lenghtC = cipher.Length;

            // make the same lenght
            if (cipher.Length<input.Length)
            {
                for (int i = 0; i<(input.Length - cipher.Length);i++)
                {
                    int indexToAd = i % cipher.Length;
                    cipherAD.Append(cipher[indexToAd]);
                }
                Console.WriteLine(cipherAD);
            }
            // perform XOR now the y are the same lenght

            char[] cipherARR = cipherAD.ToString().ToCharArray();
            char[] inputARR = inputAd.ToString().ToCharArray();
            StringBuilder finalResult = new StringBuilder();

            for (int i=0; i<cipherARR.Length; i++)
            {
               char result =  inputARR[i] ^= cipherARR[i];
               finalResult.Append(result);
            }
            Console.WriteLine(finalResult);
        }
    }
}
