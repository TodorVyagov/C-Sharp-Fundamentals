using System;
using System.Linq;

namespace MissCat2011
{
    class MissCat2011
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int voteOfRefree;
            int[] vote = new int[10];
            for (int i = 0; i < N; i++)
            {
                voteOfRefree = int.Parse(Console.ReadLine());
                for (int j = 0; j < 10; j++)
                {
                    if (voteOfRefree == (j + 1))
                    {
                        vote[j]++;
                    }
                }
            }
            int winner = 0;
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                if (vote[i] > counter)
                {
                    counter = vote[i];
                    winner = i + 1;
                }
            }
            Console.WriteLine(winner);

        }
    }
}