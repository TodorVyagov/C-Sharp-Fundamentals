using System;

namespace SumOfFractions
{
    class SumOfFractions
    {
        static void Main()
        {
            //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

            Console.WriteLine("This program calculates the sumS = 1 + 1!/X + 2!/X^2 + ... + N!/X^N for given two integer numbers N and X");
            int N, X;
            do
            {
                Console.Write("Please enter valid data(1 < N < 28)\nN = ");
                N = int.Parse(Console.ReadLine());
                Console.Write("X = ");
                X = int.Parse(Console.ReadLine());
            } while (N < 1 || N > 27); 
            //N has to be positive number, because it's factorial. 
            //For N > 27 there is overflow, but we have to use floating point variable, because there are fractions.
            //Otherwise we could use BigInteger

            decimal factorial = 1M;
            decimal powerX;
            decimal sum = 1M;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
                powerX = (decimal)Math.Pow(X, i);
                sum += factorial / powerX; 
            }
            Console.WriteLine("Sum = 1 + 1!/X + 2!/X^2 + … + N!/X^N  = {0: 0.00000}", sum);
        }
    }
}
