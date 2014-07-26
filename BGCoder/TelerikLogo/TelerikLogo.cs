using System;

namespace ExamPreparation
{
    class TelerikLogo
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            int rows = 3 * X - 2;
            int cols = (X / 2) * 2 + 2 * X - 1;
            char[,] logo = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    logo[i, j] = '.';
                }
            }
            //filled in with "."
            int currentRow = X / 2;
            int currentLeftCol = 0;
            int currentRightCol = cols - 1;

            for (int i = currentRow; i >= 0; i--)
            {
                logo[currentRow, currentLeftCol] = '*';
                logo[currentRow, currentRightCol] = '*';
                currentLeftCol++;
                currentRightCol--;
                if (currentRow == 0)
                {
                    currentRow++;
                    break;
                }
                currentRow--;
            }
            for (int i = currentRow; i < X; i++)
            {
                logo[currentRow, currentLeftCol] = '*';
                logo[currentRow, currentRightCol] = '*';
                currentRow++;
                currentLeftCol++;
                currentRightCol--;
            }
            currentLeftCol -= 2;
            currentRightCol += 2;
            for (int i = currentRow; i < (2 * X - 1); i++)
            {
                logo[currentRow, currentLeftCol] = '*';
                logo[currentRow, currentRightCol] = '*';
                currentRow++;
                currentLeftCol--;
                currentRightCol++;
            }
            currentLeftCol += 2;
            currentRightCol -= 2;
            for (int i = currentRow; i < rows; i++)
            {
                logo[currentRow, currentLeftCol] = '*';
                logo[currentRow, currentRightCol] = '*';
                currentRow++;
                currentLeftCol++;
                currentRightCol--;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(logo[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
