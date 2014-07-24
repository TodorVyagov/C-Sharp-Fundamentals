using System;

namespace ExchangeValueOfTwoIntegers
{
    class ExchangeValueOfTwoIntegers
    {
        static void Main()
        {
            //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
            Console.Write("Enter two numbers:\nFirst: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second: ");
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                int thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            Console.WriteLine("If first number is greater than second their values will be exchanged.\nFirst number: {0}\nSecond number: {1}", firstNumber, secondNumber);
        }
    }
}

