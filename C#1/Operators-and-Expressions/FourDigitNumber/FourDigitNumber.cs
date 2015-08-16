using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Please enter four digit number: ");
            string number = Console.ReadLine();
            int first = int.Parse(number[0].ToString());
            int second = int.Parse(number[1].ToString());
            int third = int.Parse(number[2].ToString());
            int fourth = int.Parse(number[3].ToString());

            bool firstDigit = true;
            if (first == 0)
            {
                Console.WriteLine("the first Digit cannot be 0");
            }
            
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", first, second, third, fourth);
            Console.WriteLine("The sum of the digits is {0}", first + second + third + fourth);
            Console.WriteLine("The digits in reversed order: {3}{2}{1}{0}", first, second, third, fourth);
            Console.WriteLine("Last digit in first position: {3}{0}{1}{2}", first, second, third, fourth);
            Console.WriteLine("The second and third digits exchanged: {0}{2}{1}{3}", first, second, third, fourth);

            



        }
    }

