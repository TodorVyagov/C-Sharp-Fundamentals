using System;

class AstrologicalDigits
{
    static void Main()
    {
        string N = Console.ReadLine();
        int astroDigit = 10;

        while (astroDigit > 9)
        {
            astroDigit = 0;
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] != '-' && N[i] != '.')
                {
                    int currentDigit = N[i] - '0';
                    astroDigit += currentDigit;
                }
            }
            N = astroDigit.ToString();
        }

        Console.WriteLine(astroDigit);
    }
}