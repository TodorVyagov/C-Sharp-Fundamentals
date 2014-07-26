using System;

class UKFlag
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int rows = N / 2;
        int cols = N;
        char[,] flag = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                flag[i, j] = '.';
            }
            for (int j = 0; j < cols; j++)
            {
                if (i == j)
                {
                    flag[i, j] = '\\';
                    flag[i, cols - 1 - j] = '/';
                }
                if (j == rows)
                {
                    flag[i, j] = '|';
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(flag[i, j]);
            }
            Console.WriteLine();
        }
        Console.Write(new string('-', rows));
        Console.Write('*');
        Console.WriteLine(new string('-', rows));
        for (int i = rows - 1; i >= 0; i--)
        {
            for (int j = cols - 1; j >=0; j--)
            {
                Console.Write(flag[i, j]);
            }
            Console.WriteLine();
        }
    }
}
