using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            string kString = Convert.ToString(K);
            int rightDigit = kString[kString.Length - 1] - '0';
            K /= 10;
            K += rightDigit * (int)Math.Pow(10, kString.Length - 1);
        }

        Console.WriteLine(K);
    }
}
