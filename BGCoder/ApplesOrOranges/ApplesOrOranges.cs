using System;

class ApplesOrOranges
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        if (number < 0)
        {
            number *= -1;
        }
        string numberString = number.ToString();
        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < numberString.Length; i++)
        {
            int currentDigit = numberString[i] - '0';

            if (currentDigit % 2 == 0)
            {
                evenSum += currentDigit;
            }
            else
            {
                oddSum += currentDigit;
            }
        }

        if (evenSum > oddSum)
        {
            Console.WriteLine("apples " + evenSum);
        }
        else if (evenSum < oddSum)
        {
            Console.WriteLine("oranges " + oddSum);
        }
        else //evenSum == oddSum
        {
            Console.WriteLine("both " + evenSum);
        }
    }
}
