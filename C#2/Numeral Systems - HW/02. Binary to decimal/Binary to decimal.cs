using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter binary number:");
            string n = Console.ReadLine();
            char[] binaryArr = n.ToCharArray();
            
            if (binaryArr[0]=='1')
            {
                Console.WriteLine("the number is negative");
                char[] binaryPositive = new char[binaryArr.Length - 1];// vzimame vsi4ki bez purvia char 1;
                for (int i = 0; i < binaryPositive.Length; i++ )
                {
                    binaryPositive[i] = binaryArr[i + 1];
                }
                Console.WriteLine(string.Join("", binaryPositive));
                Array.Reverse(binaryPositive);
                Console.WriteLine(string.Join("", binaryPositive));

                int number = 0;
                    for (int i = 0; i <binaryPositive.Length; i++)
                    {
                        number+=(binaryPositive[i] -'0')*((int)Math.Pow(2, i));  // za da go vzememe kato 4islo a ne char                      
                    }
                    number = -(int.MaxValue - number + 1);//!!!!!
                    Console.WriteLine("The decimal negative number is {0}",number);
            }

            // for positive 

            int numberDecimal = 0;
            Array.Reverse(binaryArr);
            for (int i = 0; i < binaryArr.Length; i++)
            {
                numberDecimal+= (binaryArr[i] - '0') * ((int)Math.Pow(2, i));  // za da go vzememe kato 4islo a ne char                      
            }
            Console.WriteLine("The positive decimal number is {0}", numberDecimal);

        }
    }
}
