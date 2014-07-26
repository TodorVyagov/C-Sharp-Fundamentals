using System;

class PeaceOfCake
{
    static void Main()
    {
        checked
        {
            ulong A = ulong.Parse(Console.ReadLine());
            ulong B = ulong.Parse(Console.ReadLine());
            ulong C = ulong.Parse(Console.ReadLine());
            ulong D = ulong.Parse(Console.ReadLine());

            if ((A * D + C * B) / (B * D) >= 1)
            {
                Console.WriteLine((A * D + C * B) / (B * D));
            }
            else
            {
                Console.WriteLine("{0:F22}", (decimal)(A * D + C * B) / (B * D));
            }

            Console.WriteLine((A * D + C * B) + "/" + (B * D));
        }
    }
}
