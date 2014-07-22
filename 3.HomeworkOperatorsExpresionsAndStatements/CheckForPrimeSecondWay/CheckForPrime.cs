using System;

namespace CheckForPrimeSecondWay
{
    class CheckForPrime
    {
        static void Main()
        {
            //This is much more inteligent way to solve the problem.
            Console.Write("Enter number <=100 to check if it is prime : ");
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter > 0 ? "Number {0} is composite." : "Number {0} is prime.", number);
        }
    }
}
