using System;

class Trapezoid
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int rows = N + 1;
        int cols = 2 * N;
        char[,] matrix = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = '.';
            }
        }

        //Building right side of trapezoid
        for (int i = 0; i < rows; i++)
        {
            matrix[i, cols - 1] = '*';
        }

        //Top and bottom
        for (int i = 0; i < cols; i++)
        {
            matrix[rows - 1, i] = '*';
            if (i > cols / 2 - 1)
            {
                matrix[0, i] = '*';
            }
        }

        //Diagonal
        for (int i = rows - 1, j = 0; i > 0 ; i--, j++)
        {
            matrix[i, j] = '*';
        }

        //Printing:
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
