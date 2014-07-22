using System;

namespace CheckThirdDigit
{
    class CheckThirdDigit
    {
        static void Main()
        {
            Console.Write("Enter number with 3 or more digits: ");
            int number = int.Parse(Console.ReadLine());
            number = number / 100;
            Console.WriteLine((number % 10 == 7) ? "Third digit(right-to-left) of your number is 7" : "Third digit(right-to-left) of your number isn't 7.");
        }
    }
}
//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

