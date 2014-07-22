using System;

namespace Convert254toHexAndDeclare
{
    class Convert254toHexAndDeclare
    {
        static void Main()
        {
            Console.WriteLine("There are many ways to convert decimal number to hexadecimal.\nMaybe the easiest way is to convert it in the calculator.\nI prefer to convert it to binary and then to hexadecimal.\nSo 254(10) = 1111 1110(2) = FE(16)");
            int hexNumber = 0xFE;
            Console.WriteLine(hexNumber); //We declared it as hexadecimal, but it prints 254(it's decimal value).
        }
    }
}
//Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.
