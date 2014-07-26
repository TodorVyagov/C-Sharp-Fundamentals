using System;

class NaBabaMiSmetalnika
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int[,] grid = new int[8, width];

        for (int i = 0; i < 8; i++) //Filled in the "smetalo"
        {
            int currentNum = int.Parse(Console.ReadLine());

            for (int j = 0; j < width; j++)
            {
                grid[i, width - 1 - j] = ((currentNum >> j) & 1);
            }
        }

        while (true) //Main part of the program that reads commands from "baba"
        {
            string command = Console.ReadLine();

            if (command == "left")
            {
                int targetRow = int.Parse(Console.ReadLine());
                int targetCol = int.Parse(Console.ReadLine());

                if (targetCol < 0)
                {
                    targetCol = 0;
                }
                else if (targetCol >= width)
                {
                    targetCol = width - 1;
                }

                CounterOfOnes(grid, targetRow, 0, targetCol, command);
            }
            else if (command == "right")
            {
                int targetRow = int.Parse(Console.ReadLine());
                int targetCol = int.Parse(Console.ReadLine());

                if (targetCol < 0)
                {
                    targetCol = 0;
                }
                else if (targetCol >= width)
                {
                    targetCol = width - 1;
                }

                CounterOfOnes(grid, targetRow, targetCol, width - 1, command);
            }
            else if (command == "reset")
            {
                for (int i = 0; i < 8; i++)
                {
                    CounterOfOnes(grid, i, 0, width - 1, command);
                }
            }
            else //stop
            {
                break;
            } //ready
        }

        long sum = 0;

        for (int i = 0; i < 8; i++) // sum of all the lines as numbers
        {
            long currentNum = 0;

            for (int j = 0; j < width; j++)
            {
                if (grid[i, width - 1 - j] == 1)
                {
                    long temp = 1;
                    currentNum |= temp << j;
                }
            }
            sum += currentNum;
        }
        int counterOfEmptyCols = 0;

        for (int col = 0; col < width; col++) //checks and counts if there are any empty cols
        {
            int currentColCounter = 0;

            for (int row = 0; row < 8; row++)
            {
                if (grid[row, col] == 1)
                {
                    currentColCounter++;
                }
            }

            if (currentColCounter == 0)
            {
                counterOfEmptyCols++;
            }
        }

        Console.WriteLine(sum * counterOfEmptyCols);

        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < width; j++)
        //    {
        //        Console.Write(grid[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }

    static void CounterOfOnes(int[,] matrix, int row, int startCol, int lastCol, string leftOrRight)
    {
        int counter = 0;

        for (int i = startCol; i <= lastCol; i++)
        {
            if (matrix[row, i] == 1)
            {
                counter++;
                matrix[row, i] = 0; 
            }
        }

        if (leftOrRight == "left" || leftOrRight == "reset")
        {
            for (int i = 0; i <= lastCol; i++)
            {
                if (counter > 0)
                {
                    matrix[row, i] = 1;
                    counter--;
                }
                else
                {
                    break;
                }
            }
        }
        else //right
        {
            for (int i = lastCol; i >= startCol; i--)
            {
                if (counter > 0)
                {
                    matrix[row, i] = 1;
                    counter--;
                }
                else
                {
                    break;
                }
            }
        }
    }
}

