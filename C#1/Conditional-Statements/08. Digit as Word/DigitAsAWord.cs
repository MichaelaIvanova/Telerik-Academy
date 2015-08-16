using System;

    class DigitAsAWord
    {
        //Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
        static void Main()
        {
        
       Console.Write("Type digit: "); 
       string digit = Console.ReadLine();

        int n;
        bool isNumeric = int.TryParse(digit, out n);
        if (isNumeric)
        {
            int intdigit = int.Parse(digit);
            if (intdigit >= 0 && intdigit < 10)
            {
                switch(intdigit)
                {
                    case 0: Console.WriteLine("zero");  break;
                    case 1: Console.WriteLine("one");   break;
                    case 2: Console.WriteLine("two");   break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four");  break;
                    case 5: Console.WriteLine("five");  break;
                    case 6: Console.WriteLine("six");   break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine");  break;
                    default: Console.WriteLine("not a digit"); break;
                }
            } 
            else 
            
            {
                Console.WriteLine("not a digit");
            }
        }
        else
        {
            Console.WriteLine("not a digit");
        }
    }
}


        }
    }

