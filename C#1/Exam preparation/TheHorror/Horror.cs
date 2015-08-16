using System;

    class Horror
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int counter = 0;
            int evencounter = 0;
            int sum = 0;

            foreach (char symbol in input)
            {
                if ((counter%2)==0)
                {
                    if(char.IsDigit(symbol))
                    {
                    evencounter++;
                    sum += symbol - '0'; 
                     } 
                
                }
                 ++counter;  
            }
            Console.WriteLine("{0} {1}", evencounter, sum);
        }
    
    }


