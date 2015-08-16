using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining___Classes___part_1__HW
{
    class GSMTest
    {
        static void Main()
        {
            // 7. test GSM class

            Console.WriteLine("Task 7: Write a class GSMTest to test the GSM class");

            Battery battery = new Battery("LiLon 2200", 20, 5);
            Display display = new Display(5, 1000000000);
            GSM tel1 = new GSM("S5mini", "Samsung", 3.2, "i", battery, display);
            GSM tel2 = new GSM("Alpha 5", "Samsung", 3.2, "i", battery, display);
            GSM tel3 = new GSM("Xperia Z", "Sony", 700, "Dwayne Johnson", battery, display);

            GSM[] telephones = new GSM[] { tel1, tel2, tel3 };

            foreach (GSM tel in telephones)
            {
                Console.WriteLine(tel);
            }

            Console.WriteLine(GSM.iPhone4S);

        }
    }
}
