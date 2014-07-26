using System;

namespace CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main()
        {
            int[] N = new int[5];
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }
            double[] coffeeChange = { 0.05, 0.1, 0.2, 0.5, 1 };

            double A = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double coinsInMachine = 0;
            for (int i = 0; i < 5; i++)
            {
                coinsInMachine += N[i] * coffeeChange[i];
            }
            if (A - P < 0)
            {
                Console.Write("More ");
                Console.WriteLine("{0:0.00}", P - A);
            }
            else
            {
                double change;
                change = A - P;
                if (change <= coinsInMachine)
                {
                    Console.WriteLine("Yes {0:0.00}", coinsInMachine - change);
                }
                else
                {
                    Console.WriteLine("No {0:0.00}", change - coinsInMachine);
                }
            }
        }
    }
}
