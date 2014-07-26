using System;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int rows = N;
            int cols = N;
            char[,] path = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    path[i , j] = '.';
                }
            }
            for (int i = 0, j = 0; i < rows; i++)
            {
                    path[i, i] = '*';
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(path[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = rows - 2; i >= 0; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(path[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
