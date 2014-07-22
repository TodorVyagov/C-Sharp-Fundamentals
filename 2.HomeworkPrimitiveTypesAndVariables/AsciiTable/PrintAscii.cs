using System;

namespace PrintAscii
{
    class PrintAscii
    {
        static void Main()
        {
            for (byte i = 0; i < 128; i++)
            {

                Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }

}
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.
