using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining___Classes___part_1__HW
{
    class GSM_Test
    {
         static void Main()
        {
            GSM test1 = new GSM("Samsung", "Samsung C&T Corporation", 140000, "HappyOwner",
                        new Battery("High-Tech-Battery", 1000, 10000),
                        new Display(1000, 16000000));

            GSM test2 = new GSM("Ung", "Samsung C&T Corporation", 140000, "HappyOwner",
                        new Battery("High", 1000, 10000),
                        new Display(1000, 16000000));

            GSM test3 = new GSM("Sony", "Sony Corporation", 100, "Me&Myself", new Battery(), new Display());

            GSM[] allPhones = { test1, test2, test3 };

            foreach (var gsm in allPhones)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.iPhone4S.ToString());

            GSMCallHistoryTest test = new GSMCallHistoryTest();
            test.CallHIstoryTest();
        }
       

    }
}
