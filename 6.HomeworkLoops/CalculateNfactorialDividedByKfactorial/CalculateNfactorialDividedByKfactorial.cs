using System;
using System.Numerics;

namespace CalculateNfactorialDividedByKfactorial
{
    class CalculateNfactorialDividedByKfactorial
    {
        static void Main()
        {
            //Write a program that calculates N!/K! for given N and K (1 < K < N).
            Console.WriteLine("This program will calculate N!/K!");
            int N, K;
            do
            {
            Console.Write("Please enter valid N and K(N > K > 1)\nEnter N = ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Enter K = ");
            K = int.Parse(Console.ReadLine());
            } while (K <= 1 || K >= N);
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;

            for (int i = N; i > 0; i--)
            {
                factorialN *= i;
            }
            for (int i = K; i > 0; i--)
            {
                factorialK *= i;
            }
            BigInteger factorialNDividedByFactorialK = factorialN / factorialK;
            Console.WriteLine("N! = " + factorialN);
            Console.WriteLine("K! = " + factorialK);
            Console.WriteLine("N! / K! = " + factorialNDividedByFactorialK);
        }
    }
}
