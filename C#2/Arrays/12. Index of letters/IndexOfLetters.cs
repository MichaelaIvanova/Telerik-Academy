using System;

    class IndexOfLetters
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z).
        //Read a word from the console and print the index of each of its letters in the array.
        static void Main()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            string word = Console.ReadLine();
            char[] wordArr = word.ToCharArray();

            // THIS PRINT THE NUMBER OF THE LETTER IN THE ALPHABET ARRAY FORM 1 TO 26
            foreach (char symbol in wordArr)
            {
                //Find index of SYMBOL IN ARRAY APLAHA.
                int index = Array.IndexOf(alpha, symbol);

                Console.WriteLine("{0} is in the alphabet number {1}", symbol, index+1);// WORKS ONLY WITH CApLOGS                            
            }

            // in THE ASCII TABLE:
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            foreach (char symbol in wordArr)
            {
                Console.WriteLine("{0} in ASCII is number {1}", symbol, (int) (symbol));
            }



        }
    }

