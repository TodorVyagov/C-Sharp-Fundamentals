using System;
using System.Numerics;

namespace CalculationWithFactorialsNAndK
{
    class CalculationWithFactorialsNAndK
    {
        static void Main()
        {
            //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

            Console.WriteLine("This program calculates  N!*K! / (K-N)! for given N and K.");
            int K, N;
            do
            {
                Console.Write("Please enter valid data (K > N > 1).\nEnter K = ");
                K = int.Parse(Console.ReadLine());
                Console.Write("Enter N = ");
                N = int.Parse(Console.ReadLine());
            } while (K <= N || N <= 1);
            BigInteger factorialK = 1;
            BigInteger factorialN = 1;
            BigInteger factorialKMinusN = 1;
            int kMinusN = K - N;
            for (int i = 1; i <= K; i++)
            {
                factorialK *= i;
                if (i <= N)
                {
                    factorialN *= i;
                }
                if (i <= kMinusN)
                {
                    factorialKMinusN *= i;
                }
            }
            BigInteger result = (factorialK * factorialN) / factorialKMinusN;
            Console.WriteLine("K! = " + factorialK);
            Console.WriteLine("N! = " + factorialN);
            Console.WriteLine("(K - N)! = " + factorialKMinusN);
            Console.WriteLine("N! * K! / (K - N)! = " + result);
        }
    }
}
