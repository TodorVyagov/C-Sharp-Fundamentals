using System;

namespace FallDown
{
    class FallDown
    {
        static void Main()
        {
            //Input
            int[] numbers = new int[8];
            for (int i = 0; i < 8; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //for (int i = 0; i < 8; i++)
            //{
            //    //Console.WriteLine(Convert.ToString(numbers[i], 2).PadLeft(8, '0'));
            //}
            //Console.WriteLine();

            //Solution
            for (int i = 0; i < 7; i++)
            {
                for (int line = 7; line > 0; line--)
                {
                    
                    for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                    {
                        
                        if ((((numbers[line] >> bitPosition) & 1) == 0) && ((numbers[line - 1] >> bitPosition & 1) == 1))
                        {
                            numbers[line] |= (1 << bitPosition);
                            numbers[line - 1] ^= (1 << bitPosition);
                        }
                    }

                }
                
            }

            //Output
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(numbers[i]);
                //Console.WriteLine(Convert.ToString(numbers[i], 2).PadLeft(8, '0'));
            }
        }
    }
}
