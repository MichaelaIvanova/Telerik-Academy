using System;


    class OddAndEvenProduct
    {
        //You are given n integers (given in a single line, separated by a space).
        //Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
        //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
        static void Main()
        {
            Console.WriteLine("Enter integers, separated by space:");
            string lineOFnumbers = Console.ReadLine();
            string [] numbers = lineOFnumbers.Split(' ');

            int [] numbersN = Array.ConvertAll(numbers, int.Parse);

            int productOdds = 1;
            int productEven = 1;

            for (int i = 0; i<numbersN.Length; i++)
            {
                if (i%2 != 0)
                {
                    productOdds *= numbersN[i];
                    
                }
                else
                {
                    productEven *= numbersN[i];
                    
                }
                
            }
            Console.WriteLine("Product ODDS = {0}", productOdds);
            Console.WriteLine("Product EVEN = {0}", productEven);

            if (productOdds == productEven)
            {
                Console.WriteLine("product = {0}", productOdds);
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("odd_productt = {0}", productOdds);
                Console.WriteLine("even_product = {0}", productEven);
                Console.WriteLine("no");
            }





        }
    }

