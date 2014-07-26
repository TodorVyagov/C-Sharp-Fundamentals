using System;

class OddNumber
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        long num;
        long result = 0;

        for (int i = 0; i < N; i++)
        {
            num = long.Parse(Console.ReadLine());
            result ^= num;
        }

        Console.WriteLine(result);
    }
}
