using System;

    class NullArithmetics
    {
        static void Main()
        {
            int? nullInteger = null;
            double? nullDouble = null;
         
            Console.WriteLine("Integer with value Null: " + nullInteger);
            Console.WriteLine("Double with value Null: " + nullDouble);
            

            nullInteger = 23232;
            nullDouble = 12121.1212;

            Console.WriteLine("Integer with new value: " + nullInteger);
            Console.WriteLine("Double with new value: " + nullDouble);

        }
    }

