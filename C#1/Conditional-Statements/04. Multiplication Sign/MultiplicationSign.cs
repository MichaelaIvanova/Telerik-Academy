using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            double c = int.Parse(Console.ReadLine());
            
            if ( (a > 0 && b > 0 && c > 0) || ( a < 0&& b<0 && c> 0))
            {
                Console.WriteLine("+");
            }
            else if ( (a < 0 && b < 0 && c < 0) || ( a < 0&& b>0 && c> 0) )
            {
                Console.WriteLine("-");
            }
            else if ((b < 0) && (c > 0) && a==0 )
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }

