using System;

namespace BoolIfPBitIs1
{
    class BoolIfPBitIs1
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter which bit to check if it is 1(counting from 0 to 31): ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("{0, -10} {1, 35}","Number=" , Convert.ToString(v, 2).PadLeft(32, '0'));
            int mask = 1 << p;
            Console.WriteLine("{0, -10} {1, 35}","mask=", Convert.ToString(mask, 2).PadLeft(32, '0'));
            int bit = v & mask;
            Console.WriteLine("{0, -10} {1, 35}", "bit=", Convert.ToString(bit, 2).PadLeft(32, '0'));
            bit = bit >> p;
            Console.WriteLine("{0, -10} {1, 35}", "moved bit=", Convert.ToString(bit, 2).PadLeft(32, '0'));
            Console.WriteLine("Bit number {0} in number {1} is {2}.", p, v, bit);
            bool compare = (bit == 1);
            Console.WriteLine(compare);
        }
    }
}
