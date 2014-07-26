using System;

namespace SubsetSums
{
    class SubsetSums
    {
        static void Main()
        {
            long Sum = long.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            long[] subsetArray = new long[N];
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                subsetArray[i] = long.Parse(Console.ReadLine());
            }
            for (int subset = 1; subset < (1 << N); subset++)
            {
                long targetSum = 0;
                for (int j = 0; j < N; j++)
                {
                    if (((subset >> j) & 1) == 1)
                    {
                        targetSum += subsetArray[j];
                    }
                }
                if (targetSum == Sum)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
