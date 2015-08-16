using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    // Problem 5. Generic class
    ///Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    //Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    //Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
    //Check all input parameters to avoid accessing elements at invalid positions.
    public class GenList<T>
        where T : IComparable<T>
    {
        private const uint DefaultCapacity = 1;// da subere pri deklaraciata 1 element
        private T[] arr;

        // Public Properties
        public uint Count { get; private set; }
        public uint Capacity { get; private set; }

        // public constructor
        public GenList(uint capacity = DefaultCapacity)// suzdavame go prazen
        {
            this.Capacity = capacity;
            this.Count = 0;//prazen e
            arr = new T[this.Capacity];// lenght
        }
        // public methods dding element, accessing element by index, removing element by index, 
        //inserting element at given position, clearing the list, 
        //finding element by its value and ToString().

        // we need to make a metthod to change capacity and use it every time

        public void ChangeSize(uint capacity)//neprekusnatao m podavame stojnost
        {
            //6. Auto-grow, ne moje6 predi da si go napravil 
            uint oldCapacity = this.Capacity;
            if (capacity == 0 || capacity ==1)
            {
                this.Capacity = 1;
            }
            if (capacity <= this.Capacity / 2)
                this.Capacity /= 2;
            if (capacity > this.Capacity)
                this.Capacity *= 2;
            if (oldCapacity != this.Capacity)// tuka samo promenqme duljinata na array
                Array.Resize(ref arr, (int)this.Capacity);
        }

        public void Add (T element)
        {
            this.Count++;
            ChangeSize(this.Count);
            this.arr[Count - 1] = element;
        }
        //removing element by index
        public void RemoveAt(uint i)
        {
            if (i > this.Count - 1)
                throw new IndexOutOfRangeException("Not a valid index");
            this.Count--;
            Array.Copy(this.arr, i + 1, this.arr, i, this.Count - i);
            ChangeSize(this.Count);
        }
        // inserting element at given position

        public void InsertElementAt(uint i, T element)
        {
            if (i > this.Count)
                throw new IndexOutOfRangeException("Not a valid index");
            this.Count++;
            ChangeSize(this.Count);// zaduljiteln predi da dobavim
            Array.Copy(this.arr, i, this.arr, i+1, Count - i - 1);
            this.arr[i] = element;           
        }

        //clearing the list
        public void Clear()
        {
            this.Capacity = DefaultCapacity;
            this.Count = 0;
            arr = new T[this.Capacity];// lenght
        }
        // get index of elemnt

        public uint GetIndexOf(T element)
        {
            uint i = (uint) Array.IndexOf(this.arr, element);

            return i;
        }
        //ToString()

        public override string ToString()
        {
            if (this.Count == 0)
                Console.WriteLine("Empty");

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(arr[i].ToString());
                sb.Append(" ");
            }

                return sb.ToString();
        }
        //Create generic methods Min<T>() and Max<T>() 
        //for finding the minimal and maximal element in the GenericList<T>.
        public dynamic Min<T>()
        {
            dynamic min = arr[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (min.CompareTo(arr[i]) > 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public dynamic Max<T>()
        {
            dynamic max = arr[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (max.CompareTo(arr[i]) < 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    
    }


}

