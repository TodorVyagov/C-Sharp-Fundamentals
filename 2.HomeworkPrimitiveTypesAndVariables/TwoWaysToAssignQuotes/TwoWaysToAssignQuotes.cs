﻿using System;

namespace TwoWaysToAssignQuotes
{
    class TwoWaysToAssignQuotes
    {
        static void Main()
        {
            string firstWay = @"The ""use"" of quotations causes difficulties."; 
            string secondWay = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(firstWay);
            Console.WriteLine(secondWay);
        }
    }
}
//Declare two string variables and assign them with following value:
//"The "use" of quotations causes difficulties."
//Do the above in two different ways: with and without using quoted strings.
