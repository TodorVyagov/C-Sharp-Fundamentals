using System;

namespace ConvertNumberToText
{
    class ConvertNumberToText
    {
        static void Main()
        {
            //* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
            //Examples:
	        //0 -> "Zero"
	        //273 -> "Two hundred seventy three"
	        //400 -> "Four hundred"
	        //501 -> "Five hundred and one"
	        //711 -> "Seven hundred and eleven"

            int number;
            do
            {
                Console.Write("Please, enter integer number between 0 and 999: ");
                number = int.Parse(Console.ReadLine());
            } while (number < 0 || number >= 1000);

            int hundreds = number / 100;
            hundreds %= 10; //this is how we find hundreds in the given number
            int decades = number / 10;
            decades %= 10;
            int digits = number;
            digits %= 10;

            int decadesDigits = decades * 10 + digits; //this will be used for numbers from 10 to 19
            string hundredsPronounce = null;
            string decadesPronounce = null;
            string digitsPronounce = null;
            switch (hundreds)
            {
                case 0: hundredsPronounce = null; break; //This could be missed, but I think it makes the program more readable.
                case 1: hundredsPronounce = "One hundred"; break;
                case 2: hundredsPronounce = "Two hundred"; break;
                case 3: hundredsPronounce = "Three hundred"; break;
                case 4: hundredsPronounce = "Four hundred"; break;
                case 5: hundredsPronounce = "Five hundred"; break;
                case 6: hundredsPronounce = "Six hundred"; break;
                case 7: hundredsPronounce = "Seven hundred"; break;
                case 8: hundredsPronounce = "Eight hundred"; break;
                case 9: hundredsPronounce = "Nine hundred"; break;
            }
            if (decades == 1)
            {
                switch (decadesDigits)
                {
                    case 10: decadesPronounce = "ten"; break;
                    case 11: decadesPronounce = "eleven"; break;
                    case 12: decadesPronounce = "twelve"; break;
                    case 13: decadesPronounce = "thirteen"; break;
                    case 14: decadesPronounce = "fourteen"; break;
                    case 15: decadesPronounce = "fifteen"; break;
                    case 16: decadesPronounce = "sixteen"; break;
                    case 17: decadesPronounce = "seventeen"; break;
                    case 18: decadesPronounce = "eighteen"; break;
                    case 19: decadesPronounce = "nineteen"; break;
                }
            }
            else
            {
                switch (decades)
                {
                    case 0: decadesPronounce = null; break;
                    case 2: decadesPronounce = "twenty"; break;
                    case 3: decadesPronounce = "thirty"; break;
                    case 4: decadesPronounce = "fourty"; break;
                    case 5: decadesPronounce = "fifty"; break;
                    case 6: decadesPronounce = "sixty"; break;
                    case 7: decadesPronounce = "seventy"; break;
                    case 8: decadesPronounce = "eighty"; break;
                    case 9: decadesPronounce = "ninety"; break;
                }
            }
            switch (digits)
            {
                case 0: digitsPronounce = null; break;
                case 1: digitsPronounce = "one"; break;
                case 2: digitsPronounce = "two"; break;
                case 3: digitsPronounce = "three"; break;
                case 4: digitsPronounce = "four"; break;
                case 5: digitsPronounce = "five"; break;
                case 6: digitsPronounce = "six"; break;
                case 7: digitsPronounce = "seven"; break;
                case 8: digitsPronounce = "eight"; break;
                case 9: digitsPronounce = "nine"; break;
            }
            if (decades == 1)
            {
                digitsPronounce = null;//Eleminating the last digit for numbers 11-19.
            }
            if (number == 0)
            {
                digitsPronounce = "Zero";
                Console.WriteLine(digitsPronounce);
            }
            else if (digits == 0 && decades == 0)
            {
                Console.WriteLine(hundredsPronounce);
            }
            else if (decades == 0 || decades == 1)
            {
                Console.WriteLine(hundredsPronounce + " and " + decadesPronounce + " " + digitsPronounce);
            }
            else
            {
                Console.WriteLine(hundredsPronounce + " " + decadesPronounce + " " + digitsPronounce);
            }
        }
    }
}
