using System;

namespace HoldValueOfPBit
{
    class HoldValueOfPBit
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("Enter value of bit(v=0 or v=1): v= ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter on which position to be put V(counting from 0 to 31): ");
            int p = int.Parse(Console.ReadLine());
            if (v == 1)
            {
                Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(32, '0'));
                int mask = v << p;
                Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
                int value = mask | numberN;
                Console.WriteLine(Convert.ToString(value, 2).PadLeft(32, '0'));
                Console.WriteLine(value);
            }
            else if (v == 0)
            {
                Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(32, '0'));
                v = 1;
                int mask = ~(v << p);
                Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
                int value = mask & numberN;
                Console.WriteLine(Convert.ToString(value, 2).PadLeft(32, '0'));
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Incorrect input! V must be 0 or 1!");
            }
        }
    }
}
