using System;

namespace PrintMaxAndMinNumbers
{
    class PrintMaxAndMinNumbers
    {
        static void Main()
        {
            //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

            Console.Write("How many numbers you want to enter. This program will print the Maximum and the Minimum of them.\nEnter N = ");
            int n = int.Parse(Console.ReadLine());
            int number;
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                number = int.Parse(Console.ReadLine());
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
                if (minNumber > number)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine("Maximum number is: " + maxNumber);
            Console.WriteLine("Minimum number is: " + minNumber);
        }
    }
}
