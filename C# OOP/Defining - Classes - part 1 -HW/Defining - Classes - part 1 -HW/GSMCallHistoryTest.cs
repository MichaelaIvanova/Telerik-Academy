using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using System.Diagnostics.Eventing.Reader;
namespace Defining___Classes___part_1__HW
{
    class GSMCallHistoryTest
    {
        //Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.
        public void CallHIstoryTest()
        {
            GSM myGSM = new GSM("galaxy", "samsung", 899.90, "Myself", new Battery("Lion", 40, 30), new Display(200, 2000));
            Call call1 = new Call(DateTime.Now, "0885121350", 345);
            Call call2 = new Call(DateTime.Now, "09876895456764567", 34);
            Call call3 = new Call(DateTime.Today, "87678875678", 20);

            List<uint> currHistoryDuration = new List<uint>();
            currHistoryDuration.Add((uint)call1.Duration);
            currHistoryDuration.Add((uint)call2.Duration);
            currHistoryDuration.Add((uint)call3.Duration);

            int sum = 0;
            for (int i = 0; i < currHistoryDuration.Count; i++)
            { sum += (int)currHistoryDuration[i]; }

            double spendMoney = (sum / 60) * 0.37;
            Console.WriteLine("Spent money for calls: {0}", spendMoney);

            List<Call> history = new List<Call>();
            history.Add(call1);
            history.Add(call2);
            history.Add(call3);
            //Remove the longest call from the history and calculate the total price again.
            history.OrderByDescending(s => s.Duration.Value);
            history.RemoveAt(0);

            int sumNew = 0;
            for (int i = 0; i < history.Count; i++)
            { sumNew += (int)history[i].Duration; }

            double finallyMoneySpend = (sum / 60) * 0.37;

            //Finally clear the call history and print it.
            foreach(var item in history)
            {
                Console.WriteLine(item.Date);
                Console.WriteLine(item.DailledPhone);
                Console.WriteLine(item.Duration);
            }

            history.Clear();


        }

    }
}
