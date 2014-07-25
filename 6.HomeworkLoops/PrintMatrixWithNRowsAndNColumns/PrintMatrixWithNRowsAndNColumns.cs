using System;

namespace PrintMatrixWithNRowsAndNColumns
{
    class PrintMatrixWithNRowsAndNColumns
    {
        static void Main()
        {
            //Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix.
            Console.WriteLine("This program prints a matrix with N rows and N columns.");
            string number;
            int n;
            bool isInteger, isPositiveAndBelow20;
            do
            {
                Console.Write("Please enter valid N (0 < N < 20)\nN = ");
                number = Console.ReadLine();
                isInteger = int.TryParse(number, out n);
                isPositiveAndBelow20 = n <= 0 || n > 20;
            } while (!isInteger || isPositiveAndBelow20);

            for (int i = 1; i <= n; i++)//this loop is for the rows
            {
                for (int j = 0; j < n; j++)//this loop is for columns
                {
                    Console.Write("{0, 2} ", i + j); //{0, 2} was needed because of the two digit numbers, try numbers up to 20, it works perfect
                }
                Console.WriteLine();
            }
        }
    }
}
