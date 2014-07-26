using System;

class BinaryDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        char[,] matrix = new char[4, 63];

        for (int i = 0; i < 4; i++) // filling in the matrix with 0
        {
            for (int j = 0; j < 63; j++)
            {
                if (i == 0 || i == 3)
                {
                    matrix[i, j] = '#';
                    if ((j + 1) % 4 == 0)
                    {
                        matrix[i, j] = '.';
                    }
                }
                else
                {
                    matrix[i, j] = '.';
                    if (j % 2 == 0)
                    {
                        matrix[i, j] = '#';
                    }
                }
            }
        }

        for (int i = 0; i < 16; i++) //replacing 0 with 1 where necessary
        {
            if (((number >> i) & 1) == 1)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = i * 4; col < ((i * 4) + 3); col++)
                    {
                        if (row % 2 == 0) // row 0 and 2 - .#.
                        {
                            if (col % 2 == 0)
                            {
                                matrix[row, col] = '.';
                            }
                            else
                            {
                                matrix[row, col] = '#';
                            }
                        }
                        else //row 1 - ##.
                        {
                            if (col != i * 4)
                            {
                                matrix[row, col] = '#';
                            }
                            else
                            {
                                matrix[row, col] = '.';
                            }
                        }
                    }
                }
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 62; j >= 0; j--)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }

    }
}
