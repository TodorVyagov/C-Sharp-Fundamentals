using System;

class Eggcelent
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int rows = N * 2;
        int cols = 3 * N + 1;
        char[,] egg = new char[rows, cols];

        //Filling matrix with dots '.';
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                egg[i, j] = '.';
            }
        }

        //Main filling
        for (int i = 0; i < rows; i++)
        {
            if (i == 0 || i == rows - 1) //First and last row
            {
                for (int j = N + 1; j < 2 * N; j++)
                {
                    egg[i, j] = '*';       
                }
            }
            else if (i >= N / 2 && i < N / 2 + N) 
            {
                egg[i, 1] = '*'; //Filling left and right side of egg
                egg[i, cols - 2] = '*';

                if (i == N - 1)
                {
                    for (int j = 2; j <= cols - 3; j++)
                    {
                        if (j % 2 == 0) // Filling the egg core
                        {
                            egg[i, j] = '@';
                        }
                        else
                        {
                            egg[i + 1, j] = '@';
                        }
                    }
                }
            }
        }

        for (int i = 0, j = N + 1; j > 0; i++, j -= 2) //Filling diagonals
        {
            egg[i, j] = '*';
            egg[i, cols - 1 - j] = '*';
            egg[rows - 1 - i, j] = '*';
            egg[rows - 1 - i, cols - 1 - j] = '*';
        }


        //Printing
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
