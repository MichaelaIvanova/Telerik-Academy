using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerable_extensions
{
    class mainSystem02
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ops = new[] { 2, 3, 4, 5, 6 ,7 };
            Console.WriteLine(ops.SumT<int>());
            Console.WriteLine(ops.ProductT<int>());
            Console.WriteLine(ops.MaxT<int>());
            Console.WriteLine(ops.MinT<int>());
            Console.WriteLine("{0:F2}",ops.AverageT<int>());

            IEnumerable<string> opsString = new [] { "2", "3", "4fff", "5ffa", "6"};
            Console.WriteLine(opsString.SumT<string>());
            Console.WriteLine(opsString.ProductT<string>());
            Console.WriteLine(opsString.MaxT<string>());
            Console.WriteLine(opsString.MinT<string>());
            Console.WriteLine("{0:F2}",opsString.AverageT<string>());
        }
    }
}
