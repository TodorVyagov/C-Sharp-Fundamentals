using System;

namespace SortThreeValuesInDescendingOrder
{
    class SortThreeValuesInDescendingOrder
    {
        static void Main()
        {
            //Sort 3 real values in descending order using nested if statements.
            //Numbers are said to be in descending order when they are arranged from the largest to the smallest number
            double numberOne;
            double numberTwo;
            double numberThree;
            Console.WriteLine("This program will sort in descending order all numbers you enter.");
            do
            {
                Console.Write("Please enter three different numbers:\nFirst = ");
                //We need double, because Real Numbers include floating point numbers.
                numberOne = double.Parse(Console.ReadLine());
                Console.Write("Second = ");
                numberTwo = double.Parse(Console.ReadLine());
                Console.Write("Third = ");
                numberThree = double.Parse(Console.ReadLine());
            } while (numberOne == numberTwo || numberOne == numberThree || numberTwo == numberThree);

            if (numberOne > numberTwo && numberOne > numberThree)
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine("{0}\n{1}\n{2}", numberOne, numberTwo, numberThree);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", numberOne, numberThree, numberTwo);
                }
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine("{0}\n{1}\n{2}", numberTwo, numberOne, numberThree);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}\n{2}", numberTwo, numberThree, numberOne);
                }
            }
            else if (numberThree > numberOne && numberThree > numberTwo)
            {
                if (numberOne > numberTwo)
                {
                    Console.WriteLine("{0}\n{1}\n{2}", numberThree, numberOne, numberTwo);
                }
                else
                {

                    Console.WriteLine("{0}\n{1}\n{2}", numberThree, numberTwo, numberOne);
                }
            }
        }
    }
}
