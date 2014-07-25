using System;

namespace PrintAll52CardsFromDeck
{

    class PrintAll52CardsFromDeck
    {

        static void Main()
        {
            //Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
            //The cards should be printed with their English names. Use nested for loops and switch-case.
            //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A; spades (♠), hearts (♥), diamonds (♦) and clubs (♣).
            string suit = null;
            string card = null;
            
            for (int i = 1; i <= 4; i++)
			{
                switch (i)
	            {
                    case 1: suit = "spades ♠"; break;
                    case 2: suit = "hearts ♥"; break;
                    case 3: suit = "diamonds ♦"; break;
                    case 4: suit = "clubs ♣"; break;
	            }
                for (int j = 1; j <= 13; j++)
			    {
			        switch (j)
                    {
                        case 1: card = "Ace"; break;                
                        case 2: 
                        case 3: 
                        case 4: 
                        case 5: 
                        case 6:
                        case 7: 
                        case 8: 
                        case 9:
                        case 10:
                            card = Convert.ToString(j); break;
                        case 11: card = "Jack"; break;
                        case 12: card = "Queen"; break;
                        case 13: card = "King"; break;
                    }
                    Console.WriteLine("{0, 7} of {1}", card, suit);
                }
                Console.WriteLine(new string('-', 30));
            }

        }
    }
}
