using System;

class AmericanPie
{
    static void Main()
    {
        decimal A = decimal.Parse(Console.ReadLine());
        decimal B = decimal.Parse(Console.ReadLine());
        decimal C = decimal.Parse(Console.ReadLine());
        decimal D = decimal.Parse(Console.ReadLine());
        decimal sum = A / B + C / D;

        if ((A / B + C / D) >= 1)
        {
            Console.WriteLine((int)(A / B + C / D));
        }
        else
        {
            Console.WriteLine("{0:F20}", sum);
        }

        decimal nominator = A * D + C * B;
        Console.WriteLine(nominator + "/" + B * D);
    }
}
