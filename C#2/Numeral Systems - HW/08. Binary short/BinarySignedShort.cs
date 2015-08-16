using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Binary_short
{
    class BinarySignedShort
    {
        static void Main(string[] args)
        {
           // Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
            
            short number = short.Parse(Console.ReadLine());// 16 +1 za znaka
            string shortNum = number.ToString();
            char[] shortArr = shortNum.ToCharArray();

            if(shortArr[0] == '-')
            {
                Console.WriteLine("the number is negative");
                char[] shortArrWithoutSign = new char[shortArr.Length - 1];//mahame znaka
                for(int i = 0; i<shortArrWithoutSign.Length; i++)
                {
                    shortArrWithoutSign[i] = shortArr[i + 1];
                }
                string shortWithOUtS = string.Join("", shortArrWithoutSign);//pravim go na cqlo
                int shortNegNum = int.Parse(shortWithOUtS);//pravim go na 4islo
                int opositevalue = short.MaxValue - shortNegNum + 1;// adding 1 !!!!!!!!!
                string binaryRepNeg = Convert.ToString(opositevalue, 2);
                binaryRepNeg.PadLeft(16, '1');// s tolko 14ki za6tot e 16 bit
                Console.WriteLine(binaryRepNeg);                


            }
            else
            {
                string binaryRepPositive = Convert.ToString(number, 2);
                Console.WriteLine(binaryRepPositive);

            }

        }
    }
}
