using System;

    class Play
    {
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
        static void Main()
        {
            Console.WriteLine("Please enter a number to assing the variable, write 1 for integer, 2 id for double, 3 is for string");
            int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                    case 1: Console.WriteLine("Enter integer:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);
                    break;
                    case 2: Console.WriteLine("Enter double:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);
                    break;
                    case 3: Console.WriteLine("Enter string:");
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                    break;
            }



        }
    }

