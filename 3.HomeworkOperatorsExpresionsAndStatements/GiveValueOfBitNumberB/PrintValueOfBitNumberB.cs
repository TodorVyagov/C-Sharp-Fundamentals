using System;

namespace GiveValueOfBitNumberB
{
    class PrintValueOfBitNumberB
    {
        static void Main()
        {
            //It's the same as exersize 10, but here we have go print value(0 or 1), in 10. we have to say true or false.
            Console.Write("Enter integer number: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Enter which bit to check if it is 1(counting from 0 to 31): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0, -10} {1, 35}", "Number=", Convert.ToString(i, 2).PadLeft(32, '0'));
            int mask = 1 << b;
            Console.WriteLine("{0, -10} {1, 35}", "mask=", Convert.ToString(mask, 2).PadLeft(32, '0'));
            int bit = i & mask;
            Console.WriteLine("{0, -10} {1, 35}", "bit=", Convert.ToString(bit, 2).PadLeft(32, '0'));
            int value = bit >> b;
            Console.WriteLine("{0, -10} {1, 35}", "moved bit=", Convert.ToString(value, 2).PadLeft(32, '0'));
            Console.WriteLine("Bit number {0} in number {1} is {2}.", b, i, value);
        }
    }
}
//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 -> value=1.
