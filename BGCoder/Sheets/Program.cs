using System;

class Program
{
    static void Main()
    {
        int Sum = int.Parse(Console.ReadLine());
        for (int i = 0; i < 11; i++)
        {
            if (((Sum >> i) & 1) == 0)
            {
                Console.WriteLine("A" + (10 - i));
            }
        }
    }
}

