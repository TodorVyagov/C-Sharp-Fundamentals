using System;

namespace SevenlandNumbers
{
    class SevenlandNumbers
    {
        static void Main()
        {
            int K = int.Parse(Console.ReadLine());

            int hundreds = K / 100;
            int decades = (K / 10) % 10;
            int ones = K % 10;

            if (ones == 6)
            {
                if (decades == 6)
                {
                    if (hundreds == 6)
                    {
                        Console.WriteLine(1000);

                    }
                    else
                    {
                        ones = 0;
                        decades = 0;
                        hundreds++;
                        Console.WriteLine("{0}{1}{2}", hundreds, decades, ones);
                    }
                }
                else
                {
                    ones = 0;
                    decades++;
                    if (hundreds == 0)
                    {
                        Console.WriteLine("{1}{2}", hundreds, decades, ones);
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{2}", hundreds, decades, ones);
                    }
                }
            }
            else
            {
                Console.WriteLine(K + 1);
            }
        }
    }
}
