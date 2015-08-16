using System;

    class BankAccountData
    {
        static void Main()
        {
            Console.WriteLine("Enter bank account holder First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter bank account holder Middle name:");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter bank account holder Last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter bank account holder balance/available amount of money:");
            long balance = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter bank name:");
            string bankName = Console.ReadLine();

            Console.WriteLine("Enter bank account holder IBAN");
            string iBan = Console.ReadLine();

            Console.WriteLine("Enter number of first credit card account:");
            string firstCreditCard = Console.ReadLine();
            Console.WriteLine("Enter number of second credit card account:");
            string secondCreditCard = Console.ReadLine();
            Console.WriteLine("Enter number of third credit card account:");
            string thirdCreditCard = Console.ReadLine();

            Console.WriteLine("{0} {1} {2}\n Balance: {3}\n Bank Name: {4}", firstName, middleName, lastName, balance, bankName);
            Console.WriteLine("IBAN: {0}\n First Credit Card: {1}\n Second Credit Card: {2}\n Third Credit Card: {3}", iBan, firstCreditCard, secondCreditCard, thirdCreditCard);

        }
    }

