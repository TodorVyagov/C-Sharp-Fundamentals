using System;

namespace BatGoikosTower
{
    class BatGoikosTower
    {
        static void Main()
        {
            int H = int.Parse(Console.ReadLine());
            char[,] leftMatrix = new char[H, H];
            char[,] rightMatrix = new char[H, H];
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    leftMatrix[i, j] = '.';
                    rightMatrix[i, j] = '.';
                }
            }
            int currentDash = 0;
            int newdash = 1;

            for (int row = 0, colLeft = H - 1; row < H; row++, colLeft--)
            {

                leftMatrix[row, colLeft] = '/';
                rightMatrix[row, row] = '\\';
                if(row == (currentDash + newdash))
                {
                    currentDash = row;
                    newdash++;

                    for (int i = colLeft + 1; i < H; i++)
                    {
                        leftMatrix[row, i] = '-';
                        rightMatrix[row, (H - i - 1)] = '-';
                    }

                }
            }

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    Console.Write(leftMatrix[i, j]);
                }

                for (int k = 0; k < H; k++)
			    {
			        Console.Write(rightMatrix[i, k]);
			    }
                Console.WriteLine();
            }

        }
    }
}
