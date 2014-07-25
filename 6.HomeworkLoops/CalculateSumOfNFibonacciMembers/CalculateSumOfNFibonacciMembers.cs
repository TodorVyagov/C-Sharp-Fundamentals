using System;
using System.Numerics;

namespace CalculateSumOfNFibonacciMembers
{
    class CalculateSumOfNFibonacciMembers
    {
        static void Main()
        {
            //Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            int N;
            Console.WriteLine("This program calculates the sum of the first N numbers of the sequence of Fibonacci.\nN has to be positive number!");
            do
            {
                Console.Write("Enter N = ");
                N = int.Parse(Console.ReadLine());
            } while (N < 0);
            BigInteger fibonacciCurrent;
            BigInteger fibonacciA = 0;
            BigInteger fibonacciB = 1;
            BigInteger sum = fibonacciA + fibonacciB;
            for (int i = 2; i < N; i++)
            {
                fibonacciCurrent = fibonacciA + fibonacciB;
                sum += fibonacciCurrent;
                if (fibonacciA < fibonacciB)
                {
                    fibonacciA = fibonacciCurrent; 
                }
                else
                {
                    fibonacciB = fibonacciCurrent;
                }
            }
            Console.WriteLine("The sum of the first {0} members of the sequence of Fibonacci is:\nSum = {1}", N, sum);
        }
    }
}
