using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeral_Systems___HW
{
    class Program
    {
        //Write a program to convert decimal numbers to their binary representation.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer:");
            int decimalNum = int.Parse(Console.ReadLine());
            int lenght = decimalNum.ToString().Length;
            List<int> binary = new List<int>();

            if(decimalNum<0)
            {
                decimalNum = int.MaxValue - Math.Abs (decimalNum) + 1 ;// becouse we have addional 1;
            }
            if (decimalNum == 0)
                Console.WriteLine(new string('0', 32));

            while (decimalNum>0)
            {
                int reminder = decimalNum % 2;
                decimalNum /= 2;
                binary.Add(reminder);
            }
            binary.Reverse();
            int binaryFinal = int.Parse(string.Join("", binary));// !!!!!!!!! za da moje da se izpozva posle kato 4islo
            Console.WriteLine(binaryFinal);

        }
    }
}
