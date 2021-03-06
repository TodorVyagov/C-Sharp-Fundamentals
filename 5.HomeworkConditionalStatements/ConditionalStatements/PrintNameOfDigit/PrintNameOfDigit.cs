﻿using System;

namespace PrintNameOfDigit
{
    class PrintNameOfDigit
    {
        static void Main()
        {
            //Write program that asks for a digit and depending on the input shows the 
            //name of that digit (in English) using a switch statement.
            int digit;
            Console.WriteLine("This program will print the name of digit you enter.");
            do
            {
                Console.Write("Please enter a digit: ");
                digit = int.Parse(Console.ReadLine());
            } while (digit < 0 || digit > 9);
            string nameOfDigit = null;
            switch (digit)
            {
                case 0: nameOfDigit = "Zero"; break;
                case 1: nameOfDigit = "One"; break;
                case 2: nameOfDigit = "Two"; break;
                case 3: nameOfDigit = "Three"; break;
                case 4: nameOfDigit = "Four"; break;
                case 5: nameOfDigit = "Five"; break;
                case 6: nameOfDigit = "Six"; break;
                case 7: nameOfDigit = "Seven"; break;
                case 8: nameOfDigit = "Eight"; break;
                case 9: nameOfDigit = "Nine"; break;
            }
            Console.WriteLine("You entered {0}", nameOfDigit);
        }
    }
}
