using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hexadecimal_to_decima
{
    class Program
    {
        //hex to dec
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
            char[] hex = hexNum.ToCharArray();
            Array.Reverse(hex);
            int numberDecimal = 0;

            string binary = Convert.ToString(Convert.ToInt64(hexNum, 16), 2);
            char[] binaryCh = binary.ToCharArray();// da vidim dali e positive ili negative
            
            if (binaryCh[0] == '0')
            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '0': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '1': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '2': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '3': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '4': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '5': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '6': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '7': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '8': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case '9': numberDecimal += (hex[i] - '0') * ((int)Math.Pow(16, i)); break;
                    case 'A': numberDecimal += 10 * ((int)Math.Pow(16, i)); break;
                    case 'B': numberDecimal += 11 * ((int)Math.Pow(16, i)); break;
                    case 'C': numberDecimal += 12 * ((int)Math.Pow(16, i)); break;
                    case 'D': numberDecimal += 13 * ((int)Math.Pow(16, i)); break;
                    case 'E': numberDecimal += 14 * ((int)Math.Pow(16, i)); break;
                    case 'F': numberDecimal += 15 * ((int)Math.Pow(16, i)); break;
                }
    
            }
            Console.WriteLine("The positive decimal number is {0}", numberDecimal);

            if (binaryCh[0] == '1')//negative
            {
                Console.WriteLine("the number is negative");
                char[] binaryPositive = new char[binary.Length - 1];// vzimame vsi4ki bez purvia char 1;
                for (int i = 0; i < binaryPositive.Length; i++)
                {
                    binaryPositive[i] = binary[i + 1];
                }
                Console.WriteLine(string.Join("", binaryPositive));
                Array.Reverse(binaryPositive);
                Console.WriteLine(string.Join("", binaryPositive));

                int number = 0;
                for (int i = 0; i < binaryPositive.Length; i++)
                {
                    number += (binaryPositive[i] - '0') * ((int)Math.Pow(2, i));  // za da go vzememe kato 4islo a ne char                      
                }
                number = -(int.MaxValue - number + 1);//!!!!!
                Console.WriteLine("The decimal negative number is {0}", number);

            }
        }
    }
}
