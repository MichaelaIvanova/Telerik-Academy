using System;

    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("Enter employee Fist Name:");
            string fistName = Console.ReadLine();
            Console.WriteLine("Enter employee Last Name:");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Enter employee Bithday:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthday.Year;
            Console.WriteLine("Employee age is: {0}", age);
            if (age > 100)
            Console.WriteLine("Error  Incorrect input");
           
            Console.Write("Enter employee gender, options only f/m: ");
            char gender = char.Parse(Console.ReadLine());
            if (gender == 'f' & gender == 'm')
            Console.ReadLine();
            if (gender != 'f' & gender != 'm')
            Console.WriteLine("Error  Incorrect input");

            Console.WriteLine("Enter employee ID:");
            long id = long.Parse(Console.ReadLine());
            if (id.ToString().Length != 10)
            Console.WriteLine("Error  Incorrect input");

            Console.WriteLine("Enter unique employee numberwe must be between 27560000 and 27569999:");
            int unumber = int.Parse(Console.ReadLine());
            if (unumber < 27560000 & unumber > 27569999)
            Console.WriteLine("Error  Incorrect input");

            Console.WriteLine("Name: {0} {1}\n Age: {2}\n Gender: {3}\n ID: {4}\n Unique Number: {5}", fistName, lastName, age, gender, id, unumber);

            

        }


  }
    

