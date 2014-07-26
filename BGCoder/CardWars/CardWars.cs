using System;
using System.Numerics;

namespace CardWars
{
    class CardWars
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            const int numberOfDrawnCards = 3;
            bool isFirstPlayerWinnerByXCard = false;
            bool isSecondPlayerWinnerByXCard = false;
            int gamesWonByFirstPlayer = 0;
            int gamesWonBySecondPlayer = 0;
            BigInteger totalFirstPlayerScore = 0;
            BigInteger totalSecondPlayerScore = 0;

            for (int i = 0; i < N; i++) //Number of rounds is N.
            {
                int currentFirstPlayerScore = 0;
                int currentSecondPlayerScore = 0;

                for (int card = 0; card < numberOfDrawnCards; card++) //This is for first player
                {
                    string cardDrawn = Console.ReadLine();
                    switch (cardDrawn)
                    {
                        case "A": currentFirstPlayerScore += 1; break;
                        case "J": currentFirstPlayerScore += 11; break;
                        case "Q": currentFirstPlayerScore += 12; break;
                        case "K": currentFirstPlayerScore += 13; break;
                        case "Z": totalFirstPlayerScore *= 2; break;
                        case "Y": totalFirstPlayerScore -= 200; break;
                        case "X": isFirstPlayerWinnerByXCard = true; break;
                        default: currentFirstPlayerScore += 12 - Convert.ToInt32(cardDrawn); break;
                    }
                }
                for (int card = 0; card < numberOfDrawnCards; card++) //For Second player
                {
                    string cardDrawn = Console.ReadLine();

                    switch (cardDrawn)
                    {
                        case "A": currentSecondPlayerScore += 1; break;
                        case "J": currentSecondPlayerScore += 11; break;
                        case "Q": currentSecondPlayerScore += 12; break;
                        case "K": currentSecondPlayerScore += 13; break;
                        case "Z": totalSecondPlayerScore *= 2; break;
                        case "Y": totalSecondPlayerScore -= 200; break;
                        case "X": isSecondPlayerWinnerByXCard = true; break;
                        default: currentSecondPlayerScore += 12 - Convert.ToInt32(cardDrawn); break;
                    }
                }
                //Checking who wins the round
                if (isFirstPlayerWinnerByXCard && isSecondPlayerWinnerByXCard) 
                {
                    totalFirstPlayerScore += 50;
                    totalSecondPlayerScore += 50;

                    isFirstPlayerWinnerByXCard = false;
                    isSecondPlayerWinnerByXCard = false;
                }
                else if (isFirstPlayerWinnerByXCard || isSecondPlayerWinnerByXCard)
                {
                    break;
                }

                if (currentFirstPlayerScore > currentSecondPlayerScore)
                {
                    gamesWonByFirstPlayer++;
                    totalFirstPlayerScore += currentFirstPlayerScore;
                }
                else if (currentFirstPlayerScore < currentSecondPlayerScore)
                {
                    gamesWonBySecondPlayer++;
                    totalSecondPlayerScore += currentSecondPlayerScore;
                }
            }

            //Printing results
            if (isFirstPlayerWinnerByXCard)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");

            }
            else if (isSecondPlayerWinnerByXCard)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");

            }
            else if (totalFirstPlayerScore > totalSecondPlayerScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", totalFirstPlayerScore);
                Console.WriteLine("Games won: {0}", gamesWonByFirstPlayer);
            }
            else if (totalFirstPlayerScore < totalSecondPlayerScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", totalSecondPlayerScore);
                Console.WriteLine("Games won: {0}", gamesWonBySecondPlayer);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", totalFirstPlayerScore);
            }
        }
    }
}
