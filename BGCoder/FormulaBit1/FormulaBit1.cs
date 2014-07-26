using System;

class FormulaBit1
{
    static void Main()
    {
        //Input
        byte[,] grid = new byte[8, 8];
        for (int i = 0; i < 8; i++)
        {
            byte currentInputNumber = byte.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                grid[i, j] = (byte)((currentInputNumber >> (7 - j)) & 1);
            }
        }

        //Solution
        int currRow = -1;
        int currCol = 7;
        int trackLenght = 0;
        int numberOfTurns = -1;
        bool isFinished = true;
        while (true)
        {
            //South direction

            if (currRow == 7 && currCol == 0)
            {
                break;
            }
            currRow++;
            if (currRow > 7 || currRow < 0)
            {
                isFinished = false;
                break;
            }
            if (grid[currRow, currCol] == 1)
            {
                isFinished = false;
                break;
            }
            numberOfTurns++;
            for (int i = currRow; i < 8; i++)
            {
                if (grid[currRow, currCol] == 0)
                {
                    trackLenght++;
                    currRow++;
                }
                else
                {
                    break;
                }
            }
            currRow--;

            //West direction
            if (currRow == 7 && currCol == 0)
            {
                break;
            }
            currCol--;
            if (currCol > 7 || currCol < 0)
            {
                isFinished = false;
                break;
            }
            if (grid[currRow, currCol] == 1)
            {
                isFinished = false;
                break;
            }
            numberOfTurns++;
            for (int i = currCol; i >= 0; i--)
            {
                if (grid[currRow, currCol] == 0)
                {
                    trackLenght++;
                    currCol--;
                }
                else
                {
                    break;
                }
            }
            currCol++;

            //North direction
            currRow--;
            if (currRow > 7 || currRow < 0)
            {
                isFinished = false;
                break;
            }
            if (grid[currRow, currCol] == 1)
            {
                isFinished = false;
                break;
            }
            numberOfTurns++;
            for (int i = currRow; i >= 0; i--)
            {
                if (grid[currRow, currCol] == 0)
                {
                    trackLenght++;
                    currRow--;
                }
                else
                {
                    break;
                }
            }
            currRow++;

            //West direction
            if (currRow == 7 && currCol == 0)
            {
                break;
            }
            currCol--;
            if (currCol > 7 || currCol < 0)
            {
                isFinished = false;
                break;
            }
            if (grid[currRow, currCol] == 1)
            {
                isFinished = false;
                break;
            }
            numberOfTurns++;
            for (int i = currCol; i >= 0; i--)
            {
                if (grid[currRow, currCol] == 0)
                {
                    trackLenght++;
                    currCol--;
                }
                else
                {
                    break;
                }
            }
            currCol++;
        }

        if (isFinished)
        {
            Console.WriteLine("{0} {1}", trackLenght, numberOfTurns);
        }
        else
        {
            Console.WriteLine("No {0}", trackLenght);
        }
    }
}
