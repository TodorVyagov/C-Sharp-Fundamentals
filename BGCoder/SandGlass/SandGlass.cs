using System;

class SandGlass
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char[,] matrix = new char[N, N];

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                matrix[row, col] = '.';
            }
        }

        for (int row = 0; row < N / 2 + 1; row++)
        {
            for (int col = row; col < N - row; col++)
            {
                if (row <= N / 2)
                {
                    matrix[row, col] = '*';
                    matrix[N - 1 - row, col] = '*';
                }
            }
        }

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
