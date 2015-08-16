using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    //Define a class BitArray64 to hold 64 bit values inside an ulong value.
    //Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
    public class BitArray64: IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }
        public ulong Number { get;  set; }

        public char[] ArrayBits
        {
            get { return this.ConvertToBinary(this.Number); }
        }


        public char this[int index]
        {
            get
            {
                if (index < 0 || index >= ArrayBits.Count())
                {
                    throw new IndexOutOfRangeException("No such index");
                }
                return this.ArrayBits[index]; }
            set
            {
                if (value != 0 && value != 1)
                    throw new ArgumentOutOfRangeException("DO it binaryyyy! only 1 or 0");
                this.ArrayBits[index] = value;
            }
        }
        //// e tova realno e foreach-a, moje da se naprav vsqkaksi 

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.ArrayBits.Length; i++)
                yield return this.ArrayBits[i] + 200;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.ArrayBits.GetEnumerator();
        }

        // private metohoda mi za convertion
        private char[] ConvertToBinary(ulong num)
        {
            List<ulong> binary = new List<ulong>();
            while (num> 0)
            {
                ulong reminder = num % 2;
                num /= 2;
                binary.Add(reminder);
            }
            binary.Reverse();

            char[] result = string.Join("", binary).PadLeft(64, '0').ToCharArray();
           // char[] result = string.Join("", binary).ToCharArray();

            return result;
        }

        public override bool Equals(object obj)
        {
            var anotherNum = obj as BitArray64;
            if (anotherNum.Number == null)
                return false;
            if (this.Number == anotherNum.Number)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.number.GetHashCode();
        }

        public static bool operator ==(BitArray64 one, BitArray64 two)
        {
            return one.Equals(two);
        }

        public static bool operator !=(BitArray64 one, BitArray64 two)
        {
            return !(one.Equals(two));
        }
        


    }
}
