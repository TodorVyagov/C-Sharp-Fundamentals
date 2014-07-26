using System;

class AngryFemaleGPS
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());

        if (N < 0)
        {
            N *= -1;
        }
        long evenSum = 0;
        long oddSum = 0;

        while (N > 0)
        {
            long currentDigit = N % 10;

            if (currentDigit % 2 == 0)
            {
                evenSum += currentDigit;
            }
            else
            {
                oddSum += currentDigit;
            }

            N /= 10;
        }

        if (evenSum > oddSum)
        {
            Console.WriteLine("right " + evenSum);    
        }
        else if (evenSum < oddSum)
        {
            Console.WriteLine("left " + oddSum);
        }
        else
        {
            Console.WriteLine("straight " + evenSum);
        }
    }
}
