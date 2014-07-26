using System;

namespace DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main()
        {
            int roundsN = int.Parse(Console.ReadLine());
            int[] beersDrank = new int[roundsN];
            int mitkoBeers = 0, vladkoBeers = 0;
            int mitkosCurrent = 8;
            int vladkosCurrent = 0;
            for (int i = 0; i < roundsN; i++)
            {
                beersDrank[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < roundsN; i++)
            {
                for (int j = 8; j >= 0; j--)
                {
                    int significantDigits = (int)Math.Pow(10, j);
                    if ((beersDrank[i] / significantDigits) != 0)
                    {
                        mitkosCurrent = j;
                        break;
                    }
                }
                while(mitkosCurrent >= vladkosCurrent)
                {
                    mitkoBeers += (beersDrank[i] / (int)Math.Pow(10, mitkosCurrent)) % 10;
                    mitkosCurrent--;
                    vladkoBeers += (beersDrank[i] / (int)Math.Pow(10, vladkosCurrent)) % 10;
                    vladkosCurrent++;
                }
                vladkosCurrent = 0;

            }
            if (mitkoBeers > vladkoBeers)
            {
                Console.WriteLine("M " + (mitkoBeers - vladkoBeers));
            }
            else if (vladkoBeers > mitkoBeers)
            {
                Console.WriteLine("V " + (vladkoBeers - mitkoBeers));
            }
            else
            {
                Console.WriteLine("No " + (mitkoBeers + vladkoBeers));
            }
        }
    }
}
