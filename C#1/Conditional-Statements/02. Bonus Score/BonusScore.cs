using System;

    class BonusScore
    {
// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
// if the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”
        static void Main()
        {
            Console.WriteLine("Enter score - range [1;10]:");
            int score = int.Parse(Console.ReadLine());

            //while (score < 1 || score > 10) 
            //{
            //    Console.WriteLine("Inavalid score!");
            //    Console.WriteLine("Enter score - range [1;10]:");
            //    return;
            //}

            //int scoreNew = int.Parse(Console.ReadLine());

            // if the score is between 1 and 3, the program multiplies it by 10

            if ( score < 1 || score >10)
            {
                Console.WriteLine("Invalid score");   
            }

            switch (score)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine("The score is {0}", score *= 10);
                break;
            }
            // If the score is between 4 and 6, the program multiplies it by 100.
            switch (score)
            {
                case 4:
                case 5:
                case 6: Console.WriteLine("The score is {0}", score *= 100);
                break;
            }
            //If the score is between 7 and 9, the program multiplies it by 1000.
            switch (score)
            {
                case 7:
                case 8:
                case 9: Console.WriteLine("The score is {0}", score *= 1000);
                break;
            }


        }
    }

