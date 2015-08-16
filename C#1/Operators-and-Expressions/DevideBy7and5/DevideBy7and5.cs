using System;

    class DevideBy7and5
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("{0} can be devided both 7 and 5", number);
            }
            else
            {
                Console.WriteLine("{0} cannot be devided by both 7 and 5", number);
            }
        }
    }

