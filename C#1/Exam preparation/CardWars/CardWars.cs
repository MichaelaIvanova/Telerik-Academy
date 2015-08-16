using System;

    class CardWars
    {
        static void Main()
        {
            int gamesN = int.Parse(Console.ReadLine());
            int player1totalScore = 0;
            int player2totalScore = 0;

            for (int i = 0; i< gamesN; i++)
            {
                int player1Hand = 0;
                int player2Hand = 0;
                bool player1X = false;
                bool player2X = false;

                // read first players cards
                for (int j=0; j<=3; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A": player1Hand += 1; break;
                        case "J": player1Hand += 11; break;
                        case "Q": player1Hand += 12; break;
                        case "K": player1Hand += 13 ; break;
                        case "X": player1X = true; break;
                        case "Y": player1Hand -=200; break;
                        case "Z": player1Hand *= 2; break;
                        default: 
                            player1Hand += 12 - int.Parse(card); break;// зависимост между картите
                    }
                }
                // read second players cards
                for (int j = 0; j <= 3; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A": player2Hand += 1; break;
                        case "J": player2Hand += 11; break;
                        case "Q": player2Hand += 12; break;
                        case "K": player2Hand += 13; break;
                        case "X": player2X = true; break;
                        case "Y": player2Hand -= 200; break;
                        case "Z": player2Hand *= 2; break;
                        default:
                            player1Hand += 12 - int.Parse(card); break;// зависимост между картите

                    }

                }
                if (player1totalScore)

            }

        }
    }

