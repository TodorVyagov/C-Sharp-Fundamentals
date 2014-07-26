using System;

namespace BitBall
{
    class BitBall
    {
        static void Main()
        {
            int[] topTeam = new int[8];
            int[] bottomTeam = new int[8];
            for (int i = 0; i < topTeam.Length; i++)
            {
                topTeam[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < bottomTeam.Length; i++)
            {
                bottomTeam[i] = int.Parse(Console.ReadLine());
            }

            int[] remainingBits = new int[8];
            for (int i = 0; i < 8; i++)
            {
                remainingBits[i] = topTeam[i] ^ bottomTeam[i];
            }

            for (int i = 0; i < 8; i++)
            {
                topTeam[i] = remainingBits[i] & topTeam[i];
                bottomTeam[i] = remainingBits[i] & bottomTeam[i];
            }
            int counterTop = 0;
            int counterBottom = 0;
            int[,] top = new int[8, 8];
            int[,] bottom = new int[8, 8];
            int[,] remaining = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    top[i, j] = (topTeam[i] >> (7 - j)) & 1;
                    bottom[i, j] = (bottomTeam[i] >> (7 - j)) & 1;
                    remaining[i, j] = (remainingBits[i] >> (7 - j)) & 1;
                    //converting each top team, bottom team and all players into twodimensional arrays for easier checking
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(top[i, j] == 1)
                    {
                        if (i == 7)
                        {
                            counterTop++;
                            continue;
                        }
                        for (int k = i + 1; k < 8; k++)
                        {
                            if (remaining[k, j] == 1)
                            {
                                break;
                            }
                            else if (k == 7 && remaining[k, j] == 0)
                            {
                                counterTop++;
                            }
                        }
                    }
                    if (bottom[i, j] == 1)
                    {
                        if (i == 0)
                        {
                            counterBottom++;
                            continue;
                        }
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (remaining[k, j] == 1)
                            {
                                break;
                            }
                            else if (k == 0 && remaining[k, j] == 0)
                            {
                                counterBottom++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("{0}:{1}", counterTop, counterBottom);
        }
    }
}
