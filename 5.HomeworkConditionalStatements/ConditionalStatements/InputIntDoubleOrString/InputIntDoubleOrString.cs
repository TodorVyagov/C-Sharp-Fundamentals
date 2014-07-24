using System;

namespace InputIntDoubleOrString
{
    class InputIntDoubleOrString
    {
        static void Main()
        {
            //Write a program that, depending on the user's choice inputs int, double or string variable.
            //If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
            //The program must show the value of that variable as a console output.

            Console.Write("Enter int, double or string variable: ");
            string intDoubleOrString = Console.ReadLine();
            int intNumber;
            double doubleNumber;
            if (int.TryParse(intDoubleOrString, out intNumber))
            {
                intNumber++;
                Console.WriteLine("You entered integer. I increased it with 1 and now your number is: " + intNumber);
            }
            else if (double.TryParse(intDoubleOrString, out doubleNumber))
            {
                doubleNumber++;
                Console.WriteLine("You entered a floating point number. I increased it with 1 and now your number is: " + doubleNumber);
            }
            else
            {
                intDoubleOrString = intDoubleOrString + "*";
                Console.WriteLine("You entered string variable. I added \"*\" at its end and now it is: " + intDoubleOrString);
            }
        }
    }
}
