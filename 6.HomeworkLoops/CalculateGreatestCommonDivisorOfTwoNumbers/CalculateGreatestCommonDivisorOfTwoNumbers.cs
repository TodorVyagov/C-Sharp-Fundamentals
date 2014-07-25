using System;

namespace CalculateGreatestCommonDivisorOfTwoNumbers
{
    class CalculateGreatestCommonDivisorOfTwoNumbers
    {
        static void Main()
        {
            //Write a program that calculates the greatest common divisor (GCD) of given two numbers. 

            Console.Write("This program calculates the greatest common divisor (GCD) of given two numbers\nEnter number one: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Ente number two: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int swap;
            while (numberOne != 0)
            {
                if (numberOne < numberTwo)
                {
                    swap = numberOne;
                    numberOne = numberTwo;
                    numberTwo = swap;
                }
                numberOne = numberOne % numberTwo;
            }
            Console.WriteLine("The greatest common divisor is {0}.", numberTwo);


        }
    }
}
