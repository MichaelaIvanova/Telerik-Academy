using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Insert you bithday");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
            
            int age = currentDate.Year - birthday.Year;
            if ((BirthMonth > ThisMonth) || ((BirthMonth == ThisMonth) && (BirthDay > Today)))
            Console.WriteLine("Your age is {0}, after 10 years will be {1}", age, (age+10));
            
        }
    }

