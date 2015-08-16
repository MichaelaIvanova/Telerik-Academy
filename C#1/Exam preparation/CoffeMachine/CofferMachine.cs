using System;

    class CofferMachine
    {
        static void Main()
        {
            double n1 = 0.05;
            double n2 = 0.10;
            double n3 = 0.20;
            double n4 = 0.50;
            double n5 = 1.00;

            int n1Amount = int.Parse(Console.ReadLine());
            int n2Amount = int.Parse(Console.ReadLine());
            int n3Amount = int.Parse(Console.ReadLine());
            int n4Amount = int.Parse(Console.ReadLine());
            int n5Amount = int.Parse(Console.ReadLine());
            double developerMoney = double.Parse(Console.ReadLine());
            double priceP = double.Parse(Console.ReadLine());
           
            double totalMoneyinMachine = n1 * n1Amount + n2 * n2Amount + n3 * n3Amount + n4 * n4Amount + n5 * n5Amount;
            double change = (developerMoney - priceP);

            if ((change >=0)&&(totalMoneyinMachine>=change))
            {
                Console.WriteLine("Yes {0:0.00}", (totalMoneyinMachine - change));
            }
            else if (change < 0)
            {
                Console.WriteLine("More {0:0.00}", (priceP - developerMoney));
            }
            else if ( (change>0) && (totalMoneyinMachine<change))
            {
                Console.WriteLine("No {0:0.00}", (change - totalMoneyinMachine));
            }
        }
    }

