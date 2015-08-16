using System;

    class NumberFrom1toN
    {
        //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
        static void Main()
      
         {
             Console.WriteLine("Enter positive integer:");
             int n = int.Parse(Console.ReadLine());
             
            for ( int i = 0; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
              


    
  
    }
}




        


