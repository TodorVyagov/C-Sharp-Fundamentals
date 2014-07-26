using System;

class Lines
{
    static void Main()
    {
        int[,] grid = new int[8, 8];
        int longestSequence = 0;
        int numberOfRepeatings = 0;

        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            
            for (int j = 0; j < 8; j++)
            {
                grid[i, j] = (currentNumber >> j) & 1;
            }
        }

        //Solution
        int currentSequence = 0;
        
        for (int row = 0; row < 8; row++)
        {
            currentSequence = 0;
            for (int col = 0; col < 8; col++)
            {
                if (grid[row, col] == 1)
                {
                    currentSequence++;
                }
                else //grid[row, col] == 0
                {
                    currentSequence = 0;
                }

                if (currentSequence == longestSequence)
                {
                    numberOfRepeatings++;
                }
                else if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    numberOfRepeatings = 1;
                }
            }
        }

        for (int col = 0; col < 8; col++)
        {
            currentSequence = 0;
            for (int row = 0; row < 8; row++)
            {
                if (grid[row, col] == 1)
                {
                    currentSequence++;
                }
                else //grid[row, col] == 0
                {
                    currentSequence = 0;
                }

                if (currentSequence == longestSequence)
                {
                    numberOfRepeatings++;
                }
                else if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    numberOfRepeatings = 1;
                }
            }
        }

        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < 8; j++)
        //    {
        //        Console.Write(grid[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        if (longestSequence == 1)
        {
            numberOfRepeatings /= 2;
        }
        Console.WriteLine(longestSequence);
        Console.WriteLine(numberOfRepeatings);

    }
}
