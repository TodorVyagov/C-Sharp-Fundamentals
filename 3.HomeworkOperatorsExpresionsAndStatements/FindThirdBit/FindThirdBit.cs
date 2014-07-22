using System;

namespace FindThirdBit
{
    class FindThirdBit
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            int mask = 1 << 3;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            int bit = number & mask;
            bit = bit >> 3;
            //also we can use (bit >>= 3;), but this is easier to read.
            Console.WriteLine("Third bit of your number is {0}", bit);
            Console.WriteLine(bit==1 ? "True" : "False");
        }
    }
}
