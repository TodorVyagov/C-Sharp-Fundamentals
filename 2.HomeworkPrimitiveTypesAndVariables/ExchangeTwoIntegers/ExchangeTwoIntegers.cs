using System;

namespace ExchangeTwoIntegers
{
    class ExchangeTwoIntegers
    {
        static void Main()
        {
            int numberOne = 5;
            int numberTwo = 10;
            int numberSwap;
            Console.WriteLine("First number is: {0}, Second number is {1}.", numberOne, numberTwo);
            numberSwap = numberOne;
            numberOne = numberTwo;
            numberTwo = numberSwap;
            Console.WriteLine("We swapped the values and now:\nFirst number is: {0}, Second number is {1}.", numberOne, numberTwo);
        }
    }
}
//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
