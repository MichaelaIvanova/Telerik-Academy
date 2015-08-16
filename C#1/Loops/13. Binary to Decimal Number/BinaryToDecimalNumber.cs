using System;

    class BinaryToDecimalNumber
    {
        //Using loops write a program that converts a binary integer number to its decimal form.
        //The input is entered as string. The output should be a variable of type long.
        //Do not use the built-in .NET functionality.
        static void Main()
        {
            string binary = Console.ReadLine();
            int[] number = new int [binary.Length];
            long decimalNum = 0;
            long degree = binary.Length-1;// degree of the last 

            for (int i = 0; i < binary.Length;  i++)
            {
                char b = binary[i];// take elementss
                number[i] = Convert.ToInt32(b.ToString());//join elements , gives binary sequence
                decimalNum +=number[i]*(long)(Math.Pow(2,degree));
                degree--;   // because binary is 2 on some degree
            }
            Console.WriteLine("{0}", decimalNum);



        }
    }

