using System;

namespace ArrangeNumbersAsSpiral
{
    class ArrangeNumbersAsSpiral
    {
        static void Main()
        {
            //Write a program that reads a positive integer number N (N < 20) from console 
            //and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

            Console.WriteLine("This program outputs is the console numbers from 1 to N arranged as a spiral.\nN has to be positive integer number.");
            int N;
            do
            {
                Console.Write("Please enter valid N (0 < N < 20)\nEnter N = ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0 || N >= 20);
            int counter = 1;
            int maxValue = N * N;
            int minRow = 0;
            int maxRow = N - 1;
            int minCol = 0;
            int maxCol = N - 1;
            int[,] matrix = new int[N, N];//we need twodimensional array
            do
            {
                for (int i = minCol; i <= maxCol ; i++)//Assigning the top row of matrix
                {
                    matrix[minRow, i] = counter;
                    counter++;
                }
                minRow++;
                for (int i = minRow; i <= maxRow; i++)//assigning the right column of matrix
                {
                    matrix[i, maxCol] = counter;
                    counter++;
                }
                maxCol--;
                for (int i = maxCol; i >= minCol ; i--)//assigning the bottom row of the matrix
                {
                    matrix[maxRow, i] = counter;
                    counter++;
                }
                maxRow--;
                for (int i = maxRow; i >= minRow; i--)//assigning the left column of the matrix
                {
                    matrix[i, minCol] = counter;
                    counter++;
                }
                minCol++;
            } while (counter <= maxValue);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0, 3}",matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
