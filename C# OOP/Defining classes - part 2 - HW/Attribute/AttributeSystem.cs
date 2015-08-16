using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    class AtributeSystem
    {
        static void Main(string[] args)
        {
            object[] versionAttributes = typeof(AtributeSystem).GetCustomAttributes(typeof(VersionAttribute), false);

            Console.WriteLine("Version: {0}", versionAttributes[0]);

        }
    }
}
