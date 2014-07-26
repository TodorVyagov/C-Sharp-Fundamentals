using System;
using System.Numerics;

namespace Secrets
{
    class Secrets
    {
        static void Main()
        {
            BigInteger Nn = BigInteger.Parse(Console.ReadLine());
            if (Nn < 0)
            {
                Nn *= (-1);
            }
            string N = Nn.ToString();
            BigInteger Sum = 0;
            char[] number = new char[N.Length];

            for (int i = 0; i < N.Length; i++)
            {
                number[N.Length - 1 - i] = N[i];
            }
            for (int i = 0; i < N.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Sum += (number[i] - '0') * (i + 1) * (i + 1);
                }
                else
                {
                    Sum += (number[i] - '0') * (number[i] - '0') * (i + 1);
                }
            }
            Console.WriteLine(Sum);
            BigInteger sequenceLenght = Sum % 10;
            char R;
            R = (char)((Sum % 26) + 'A');
            if (sequenceLenght != 0)
            {
                for (int i = 0; i < sequenceLenght; i++)
                {
                    Console.Write(R);
                    R++;
                    if (R > 'Z')
                    {
                        R = 'A';
                    }
                }
            }
            else
            {
                Console.WriteLine("{0} has no secret alpha-sequence", Nn);
            }
        }
    }
}
