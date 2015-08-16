using System;

    class PrintDeckof52Cards
    {
 //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
        //The card faces should start from 2 to A.
        // Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
        static void Main()
        {
            for (int i = 2; i <=14; i++)// 14 type of cards all of them
        {
            for (int j = 5; j < 7; j--)// ascii table
            {
                if (i < 11)
                {
                    Console.Write("{0}{1} ", i, (char)j);
                }
                switch (i)
                {
                    case 11: Console.Write("J{0} ", (char)j);
                        break;
                    case 12: Console.Write("Q{0} ", (char)j);
                        break;
                    case 13: Console.Write("K{0} ", (char)j);
                        break;
                    case 14: Console.Write("A{0} ", (char)j);
                        break;
                }
                if (j == 3)
                {
                    j = 7;
                }
                if (j == 6)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}

        
    

