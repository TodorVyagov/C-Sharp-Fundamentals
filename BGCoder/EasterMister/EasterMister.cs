using System;

class EasterMister
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int cols = 3 * N + 1;
        int rows = N * 2;
        char[,] egg = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                egg[i, j] = '.';
            }
        }

        for (int i = 0; i < rows; i++)
        {
            if (i == 0 || i == rows - 1)
            {
                for (int j = N + 1; j < (2 * N); j++)
                {
                    egg[i, j] = '*';
                }
            }
            else
            {
                if (i >= N / 2 && i <= rows - N / 2 - 1)
                {
                    egg[i, 1] = '*';
                    egg[i, cols - 2] = '*';
                }
            }

            if (i == N - 1)
            {
                for (int j = 2; j < cols - 2; j++)
                {
                    if (j % 2 != 0)
                    {
                        egg[i, j] = '#';
                    }
                    else
                    {
                        egg[i + 1, j] = '#';
                    }
                }
            }

        }

        for (int i = 1, j = N - 1; j > 0; i++, j -= 2)
        {
            egg[i, j] = '*';
            egg[i, cols - 1 - j] = '*';
            egg[rows - 1 - i, j] = '*';
            egg[rows - 1 - i, cols - 1 - j] = '*';
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(egg[i, j]);
            }
            Console.WriteLine();
        }

    }
}
