using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    class MainSysBit64
    {
        static void Main(string[] args)
        {
            BitArray64 num = new BitArray64(2345678);
            //check the bits
            Console.WriteLine(string.Join("", num.ArrayBits));
            //check index
            Console.WriteLine(num[63]);
            Console.WriteLine(num[62]);
            Console.WriteLine(num[0]);
            //check enumeratora


            foreach (var bit in num)//тук само числото слагаме, за да видим дали сме му сложили foreacha
            {
                //оставила съм го да събира номера на 1 или 0 от аски таблица с 200, за да се види ясно!
                Console.WriteLine(bit);
            }

            //вграден форич за масив
           foreach (var bit in num.ArrayBits)
           {
               //tuk si izpisva 4isloto normalno
               Console.Write(bit);
           }
           Console.WriteLine();

            // check equals

           BitArray64 anothernum = new BitArray64(234567);
           Console.WriteLine(num.Equals(anothernum));

            //chech operators == and =!
           Console.WriteLine(num == anothernum);
           Console.WriteLine(num != anothernum);
        }
    }
}
