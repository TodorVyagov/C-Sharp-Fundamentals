using System;

class Poker
{
    static void Main()
    {
        int[] hand = new int[5];

        for (int i = 0; i < 5; i++)
        {
            string handString = Console.ReadLine();

            switch (handString)
            {
                case "J": 
                    hand[i] = 11; 
                    break;
                case "Q": 
                    hand[i] = 12; 
                    break;
                case "K": 
                    hand[i] = 13; 
                    break;
                case "A": 
                    hand[i] = 1;
                    break;
                default:
                    hand[i] = int.Parse(handString);
                    break;
            }
        }
        bool isStraight = false;
        Array.Sort(hand);

        if (hand[0] == hand[4])
        {
            Console.WriteLine("Impossible");
        }
        else if (hand[0] == hand[3] || hand[1] == hand[4])
        {
            Console.WriteLine("Four of a Kind");
        }
        else if ((hand[0] == hand[1] && hand[2] == hand[4]) || (hand[0] == hand[2] && hand[3] == hand[4]))
        {
            Console.WriteLine("Full House");
        }
        else if (hand[0] == hand[2] || hand[1] == hand [3] || hand[2] == hand[4])
        {
            Console.WriteLine("Three of a Kind");
        }
        else if ((hand[0] == hand[1] && hand[2] == hand[3]) || 
            (hand[0] == hand[1] && hand[3] == hand[4]) ||
            (hand[1] == hand[2] && hand[3] == hand[4]))
        {
            Console.WriteLine("Two Pairs");
        }
        else if (hand[0] == hand[1] || hand[1] == hand[2] || hand[2] == hand[3] || hand[3] == hand[4])
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            if (hand[4] == hand[0] + 4)
            {
                isStraight = true;
            }
            else
            {
                hand[0] = 14;
                Array.Sort(hand);

                if (hand[4] == hand[0] + 4)
                {
                    isStraight = true;
                }
            }

            if (isStraight)
            {
                Console.WriteLine("Straight");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}
