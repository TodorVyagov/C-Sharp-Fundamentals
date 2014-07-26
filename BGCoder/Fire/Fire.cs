using System;

namespace Fire
{
    class Fire
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            //firetop
            char[,] fireTop = new char[N / 2, N];


            for (int i = 0; i < N / 2; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    fireTop[i, j] = '.';
                }
            }
            for (int i = 0, j = (N / 2) - 1; i < N / 2; i++, j--)
            {

                fireTop[i, j] = '#';
                fireTop[i, N - j - 1] = '#';

            }
            for (int i = 0; i < N / 2; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(fireTop[i, j]);
                }
                Console.WriteLine();
            }
            //fireBottom
            char[,] fireBottom = new char[N / 4, N];
            for (int i = 0; i < N / 4; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    fireBottom[i, j] = '.';
                }
            }
            for (int i = 0, j = 0; i < N / 4; i++, j++)
            {

                fireBottom[i, j] = '#';
                fireBottom[i, N - j - 1] = '#';

            }

            for (int i = 0; i < N / 4; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(fireBottom[i, j]);
                }
                Console.WriteLine();
            }




            Console.WriteLine(new string('-', N));
            //torch
            char[,] torch = new char[N / 2, N];
            for (int i = 0; i < N / 2; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    torch[i, j] = '.';
                }
            }
            for (int i = 0; i < N / 2; i++)
            {
                for (int j = i; j < N / 2; j++)
                {
                    torch[i, j] = '\\';
                    torch[i, N - 1 - j] = '/';
                }
            }
            for (int i = 0; i < N / 2; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(torch[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
