using System;

    class PrintCompanyInformation
    {
        // Write a program that reads the information about a company and its manager and prints it back on the console.
        static void Main()
        {
            Console.WriteLine("Enter the company name:");
            string company = Console.ReadLine();

            Console.WriteLine("Enter address - strNumber, street, city:");
            int strN = int.Parse(Console.ReadLine());
            string strNN = strN.ToString();
            string str = Console.ReadLine();
            string city = Console.ReadLine();
            string address = strNN +" "+ str +" "+ city;
            Console.WriteLine(address);

            Console.WriteLine("Enter telephone number:");
            string tel = String.Format("{0: +(359) ### ## ## ###}", int.Parse(Console.ReadLine()));
            Console.WriteLine(tel);
            Console.WriteLine("Enter first fax number:");
            string fax1 = String.Format("{0: +(359) ### ## ## ###}", int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter second fax number:");
            string fax2 = String.Format("{0: +(359) ### ## ## ###}", int.Parse(Console.ReadLine()));
            string web = Console.ReadLine();

            Console.WriteLine("Enter first and last name");
            string firstname = Console.ReadLine();
            string lastName = Console.ReadLine();
            string fullName = firstname + " " + lastName;
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone number");
            string phone = String.Format("{0: +(359) ### ## ## ###}", int.Parse(Console.ReadLine()));

            Console.WriteLine("Company:{0}\n Address: {1}\n Tel: {2}\n Fax: {3}\n{4}\n Web: {5}\n Name: {6}\n Phone: {7}",
                company, address, tel, web, fullName, phone);
        



        }
    }

