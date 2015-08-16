using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class MainSystem
    {
        static void Main(string[] args)
        {
            //Test
            GenList<int> start = new GenList<int>();
            start.Add(1);
            start.Add(2);
            start.Add(3);
            Console.WriteLine(start.Capacity);
            Console.WriteLine(start.Count);
            start.RemoveAt(2);
            Console.WriteLine(start.Count);
            start.InsertElementAt(1, 7);
            Console.WriteLine(start.Count);
            Console.WriteLine( start.ToString());
            Console.WriteLine(start.Max<int>());
            Console.WriteLine(start.Min<int>());
        }
    }
}
