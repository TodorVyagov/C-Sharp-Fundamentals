using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int remainder = number % (7 * 5); //I could put 35 directly but this looks better.
            Console.WriteLine(remainder == 0 ? "There is no remainder when you divide {0} by 7 and 5(35) at the same time." : "You can't divide {0} by 7 and 5 at the same time without remainder = {1}", number);
        }
    }
}
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
