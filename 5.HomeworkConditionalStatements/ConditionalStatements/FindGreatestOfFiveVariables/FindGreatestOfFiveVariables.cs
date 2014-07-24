using System;

namespace FindGreatestOfFiveVariables
{
    class FindGreatestOfFiveVariables
    {
        static void Main()
        {
            //Write a program that finds the greatest of given 5 variables.

            Console.Write("Enter five numbers and I will find the biggest one.\nFirst: ");
            int numberOne = int.Parse(Console.ReadLine());
            int biggest = numberOne;
            Console.Write("Second: ");
            int numberTwo = int.Parse(Console.ReadLine());
            if (biggest < numberTwo)
            {
                biggest = numberTwo;
            }
            Console.Write("Third: ");
            int numberThree = int.Parse(Console.ReadLine());
            if (biggest < numberThree)
            {
                biggest = numberThree;
            }
            Console.Write("Fourth: ");
            int numberFour = int.Parse(Console.ReadLine());
            if (biggest < numberFour)
            {
                biggest = numberFour;
            }
            Console.Write("Fifth: ");
            int numberFive = int.Parse(Console.ReadLine());
            if (biggest < numberFive)
            {
                biggest = numberFive;
            }
            Console.WriteLine("The biggest numer is " + biggest);

            //Second way is easier one is to use Loop - shorter, simpler, smarter.
            //Console.WriteLine("Enter five numbers and I will find the biggest one.");
            //int number;
            //int biggest = int.MinValue; //This is because you will be unable to enter lower value.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter number {0}: ", i + 1);
            //    number = int.Parse(Console.ReadLine());
            //    if (biggest < number)
            //    {
            //        biggest = number;
            //    }
            //}
            //Console.WriteLine("The biggest numer is " + biggest);
        }
    }
}
